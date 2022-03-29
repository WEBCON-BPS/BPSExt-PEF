using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WebCon.BpsExt.PEF.CustomActions.Models;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.CreditNote;
using WebCon.WorkFlow.SDK.Documents.Model.Fields;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.CreditNoteUBLExtensions;

namespace WebCon.BpsExt.PEF.CustomActions.ReadCreditNoteXml
{
    public class ReadCreditNoteXml : CustomAction<ReadCreditNoteXmlConfig>
    {
        StringBuilder _logger = new StringBuilder();
        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var att = GetAttachment(args.Context);
                if (att != null)
                    FillFields(att, args.Context);
                else
                    SetError(args);
            }
            catch (Exception ex)
            {
                _logger.AppendLine(ex.ToString());
                args.Message = ex.Message;
                args.HasErrors = true;
            }
            finally
            {
                args.LogMessage = _logger.ToString();
                args.Context.PluginLogger.AppendInfo(_logger.ToString());
            }
        }

        private void SetError(RunCustomActionParams args)
        {
            var msg = $"There are no attachments in category {Configuration.CategoryId}";
            _logger.AppendLine(msg);
            args.Message = msg;
            args.HasErrors = true;
        }

        private void FillFields(AttachmentData att, ActionContextInfo context)
        {
            var xml = GetXml(att);
            var creditNote = GetCreditNote(xml);
            var getter = new CreditNoteTypeGet();
            GetAttachmentsFromXml(creditNote, context);
            SetFields(creditNote, getter, context);
            SetCollections(creditNote, getter, context);
        }

        private void GetAttachmentsFromXml(CreditNoteType invoice, ActionContextInfo context)
        {
            _logger.AppendLine("Getting attachments from xml");
            GetAttachments(context, new CreditNoteAttachments(invoice.AdditionalDocumentReference, AttachmentsCategory.Additional),
                new CreditNoteAttachments(invoice.ContractDocumentReference, AttachmentsCategory.Contract),
                new CreditNoteAttachments(invoice.DespatchDocumentReference, AttachmentsCategory.Despatch),
                new CreditNoteAttachments(invoice.OriginatorDocumentReference, AttachmentsCategory.Originator),
                new CreditNoteAttachments(invoice.ReceiptDocumentReference, AttachmentsCategory.Receipt),
                new CreditNoteAttachments(invoice.StatementDocumentReference, AttachmentsCategory.Statement));
        }

        private void GetAttachments(ActionContextInfo context, params CreditNoteAttachments[] documents)
        {
            foreach (var documentType in documents ?? Enumerable.Empty<CreditNoteAttachments>())
                foreach (var document in documentType.Documents ?? Enumerable.Empty<XmlHelper.CreditNote.DocumentReferenceType>())
                    GetAttachment(document, documentType.Category, context);
        }

        private void GetAttachment(XmlHelper.CreditNote.DocumentReferenceType document, string category, ActionContextInfo context)
        {
            if (document?.Attachment?.EmbeddedDocumentBinaryObject != null)
                AddBinaryFile(document.Attachment.EmbeddedDocumentBinaryObject, category, context);
            if (document?.Attachment?.ExternalReference != null)
                AddUrlFile(document.Attachment.ExternalReference, category, context);
        }
        private void AddBinaryFile(XmlHelper.CreditNote.EmbeddedDocumentBinaryObjectType attachment, string category, ActionContextInfo context)
        {
            var att = new NewAttachmentData(attachment.filename, attachment.Value);
            AddAttachmentToCategory(att, category, context);
        }
        private void AddUrlFile(XmlHelper.CreditNote.ExternalReferenceType attachment, string category, ActionContextInfo context)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(attachment.URI.Value).Result;
                using (var stream = new MemoryStream())
                {
                    response.Content.CopyToAsync(stream).Wait();
                    var att = new NewAttachmentData(attachment.FileName.Value, stream.ToArray());
                    AddAttachmentToCategory(att, category, context);
                }
            }
        }

        private void AddAttachmentToCategory(NewAttachmentData att, string category, ActionContextInfo context)
        {
            att.SetFileGroup(category);
            context.CurrentDocument.Attachments.AddNew(att);
        }

        private void SetCollections(CreditNoteType creditNote, CreditNoteTypeGet getter, ActionContextInfo context)
        {
            _logger.AppendLine("Getting collestions from xml");
            var standardLists = context.CurrentDocument.ItemsLists.Where(x => !string.IsNullOrEmpty(x.Description) && !x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase));
            foreach (var list in standardLists)
            {
                _logger.AppendLine($"Getting collection {list.DisplayName} with xpath {list.Description}");
                var colection = new XmlCollectionMapping(list.Description, list);
                colection.ColumnsMapping = new List<IXmlColumnMapping>();
                _logger.AppendLine($"Clearing list {list.DisplayName}");
                list.Rows.Clear();
                foreach (var column in list.Columns)
                    if (!string.IsNullOrEmpty(column.Description))
                    {
                        _logger.AppendLine($"Getting column {column.DisplayName} with xpath {column.Description}");
                        var colMaping = new XmlColumnMapping(column.Description, column);
                        colection.ColumnsMapping.Add(colMaping);
                    }
                getter.GetField(creditNote, colection);
            }

            var extensionLists = context.CurrentDocument.ItemsLists.Where(x => !string.IsNullOrEmpty(x.Description) && x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase)).ToList();
            GetExtensionLists(creditNote, extensionLists);
        }

        private void GetExtensionLists(CreditNoteType creditNote, List<WorkFlow.SDK.Documents.Model.ItemLists.ItemsList> extensionLists)
        {
            var getter = new CreditNoteUBLExtensionsTypeGet();
            var groupedExtensionlists = extensionLists.GroupBy(x => GetExtensionRoot(x.Description));
            foreach (var group in groupedExtensionlists)
            {
                var key = group.Key;
                switch (group.Key)
                {
                    case "InvoiceCorrection":
                        GetInvoiceCorrectionLists(creditNote, getter, group);
                        break;
                    case "OriginalInvoiceData":
                        GetOriginalInvoiceDataLists(creditNote, getter, group);
                        break;
                }
            }
        }

        private void GetOriginalInvoiceDataLists(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeGet getter, IGrouping<string, WorkFlow.SDK.Documents.Model.ItemLists.ItemsList> group)
        {
            var invoiceCorrection = GetType<XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData>(creditNote.UBLExtensions[2].ExtensionContent);
            foreach (var list in group)
            {
                _logger.AppendLine($"Getting collection {list.DisplayName} with xpath {list.Description}");
                var colection = new XmlCollectionMapping(GetRelativePath(list.Description, group.Key), list);
                colection.ColumnsMapping = new List<IXmlColumnMapping>();
                _logger.AppendLine($"Clearing list {list.DisplayName}");
                list.Rows.Clear();
                foreach (var column in list.Columns)
                    if (!string.IsNullOrEmpty(column.Description))
                    {
                        _logger.AppendLine($"Getting column {column.DisplayName} with xpath {column.Description}");
                        var colMaping = new XmlColumnMapping(column.Description, column);
                        colection.ColumnsMapping.Add(colMaping);
                    }
                getter.GetField(invoiceCorrection, colection);
            }
        }

        private void GetInvoiceCorrectionLists(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeGet getter, IGrouping<string, WorkFlow.SDK.Documents.Model.ItemLists.ItemsList> group)
        {
            var invoiceCorrection = GetType<XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection>(creditNote.UBLExtensions[1].ExtensionContent);
                foreach (var list in group)
                {
                    _logger.AppendLine($"Getting collection {list.DisplayName} with xpath {list.Description}");
                    var colection = new XmlCollectionMapping(GetRelativePath(list.Description, group.Key), list);
                    colection.ColumnsMapping = new List<IXmlColumnMapping>();
                    _logger.AppendLine($"Clearing list {list.DisplayName}");
                    list.Rows.Clear();
                    foreach (var column in list.Columns)
                        if (!string.IsNullOrEmpty(column.Description))
                        {
                            _logger.AppendLine($"Getting column {column.DisplayName} with xpath {column.Description}");
                            var colMaping = new XmlColumnMapping(column.Description, column);
                            colection.ColumnsMapping.Add(colMaping);
                        }
                    getter.GetField(invoiceCorrection, colection);
                }
        }

        private void SetFields(CreditNoteType invoice, CreditNoteTypeGet getter, ActionContextInfo context)
        {


            _logger.AppendLine("Getting fields from xml");
            var standardFields = context.CurrentDocument.Fields.Where(x => !string.IsNullOrEmpty(x.Description) && !x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase));
            foreach (var field in standardFields)
            {
                _logger.AppendLine($"Getting field {field.DisplayName} with xpath {field.Description}");
                getter.GetField(invoice, new XmlFieldMapping(field.Description, field));
            }
            var extensionFields = context.CurrentDocument.Fields.Where(x => !string.IsNullOrEmpty(x.Description) && x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase)).ToList();
            GetExtensionFields(invoice, extensionFields);
        }

        private void GetExtensionFields(CreditNoteType invoice, List<BaseField> extensionFields)
        {
            var getter = new CreditNoteUBLExtensionsTypeGet();
            var groupedExtensionFields = extensionFields.GroupBy(x => GetExtensionRoot(x.Description));
            foreach (var group in groupedExtensionFields)
            {
                var key = group.Key;
                switch (group.Key)
                {
                    case "Comment":
                        GetComment(invoice, getter, group);
                        break;
                    case "InvoiceCorrection":
                        GetInvoiceCorrection(invoice, getter, group);
                        break;
                    case "OriginalInvoiceData":
                        GetOriginalInvoiceData(invoice, getter, group);
                        break;
                }
            }
        }

        private void GetOriginalInvoiceData(CreditNoteType invoice, CreditNoteUBLExtensionsTypeGet getter, IGrouping<string, BaseField> group)
        {
            var originalInvoice = GetType<XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData>(invoice.UBLExtensions[2].ExtensionContent);
            foreach (var field in group)
                getter.GetField(originalInvoice, new XmlFieldMapping(GetRelativePath(field.Description, group.Key), field));
        }

        private void GetInvoiceCorrection(CreditNoteType invoice, CreditNoteUBLExtensionsTypeGet getter, IGrouping<string, BaseField> group)
        {
            var invoiceCorrection = GetType<XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection>(invoice.UBLExtensions[1].ExtensionContent);
            foreach (var field in group)
                getter.GetField(invoiceCorrection, new XmlFieldMapping(GetRelativePath(field.Description, group.Key), field));
        }

        private void GetComment(CreditNoteType invoice, CreditNoteUBLExtensionsTypeGet getter, IGrouping<string, BaseField> group)
        {
            var comment = GetType<XmlHelper.CreditNoteUBLExtensions.CommentType>(invoice.UBLExtensions[0].ExtensionContent);
            foreach (var field in group)
                getter.GetField(comment, new XmlFieldMapping(GetRelativePath(field.Description, group.Key), field));
        }

        private string GetRelativePath(string path, string key)
        {
            var nextNode = path.IndexOf(key) + key.Length + 1;
            return nextNode > path.Length ? string.Empty : path.Substring(path.IndexOf(key) + key.Length + 1);
        }

        private string GetExtensionRoot(string path)
        {
            var n = 2;
            var startIndex = path.TakeWhile(c => (n -= (c == '/' ? 1 : 0)) > 0).Count() + 1;
            var endIndex = path.IndexOf('/', startIndex + 1) == -1 ? path.Length : path.IndexOf('/', startIndex + 1);
            return path.Substring(startIndex, endIndex - startIndex);
        }

        private CreditNoteType GetCreditNote(string xml)
        {
            _logger.AppendLine("Creating invoice object");
            var creditNoteType = new CreditNoteType();
            var serializer = new XmlSerializer(typeof(CreditNoteType));
            using (var reader = new StringReader(xml))
            {
                creditNoteType = (CreditNoteType)serializer.Deserialize(reader);
                return creditNoteType;
            }
        }

        private T GetType<T>(XmlElement xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(new XmlNodeReader(xml));
        }
        
       
        private string GetXml(AttachmentData att)
        {
            _logger.AppendLine("Loading xml");
            var doc = new XmlDocument();
            using (var stream = new MemoryStream(att.Content))
            {
                doc.Load(stream);
                return doc.InnerXml;
            }
        }

        private AttachmentData GetAttachment(ActionContextInfo context)
        {
            _logger.AppendLine("Downloading attachment");
            return context.CurrentDocument.Attachments.FirstOrDefault(x => x.FileGroup?.ID == Configuration.CategoryId);
        }

        private T GetInstance<T>(string type)
        {
            return (T)Activator.CreateInstance(Type.GetType(type));
        }
    }
}