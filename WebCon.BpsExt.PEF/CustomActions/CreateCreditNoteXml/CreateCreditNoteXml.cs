using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WebCon.BpsExt.PEF.CustomActions.Models;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;
using WebCon.WorkFlow.SDK.Tools.Data.Model;
using WebCon.WorkFlow.SDK.Tools.Other;
using System.Linq;
using WebCon.WorkFlow.SDK.Documents.Model.Fields;
using System.Xml.Linq;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.CreditNote;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.CreditNoteUBLExtensions;
using WebCon.BpsExt.PEF.CustomActions.Utils;
using WebCon.WorkFlow.SDK.Documents.Model.ItemLists;

namespace WebCon.BpsExt.PEF.CustomActions.CreateCreditNoteXml
{
    public class CreateCreditNoteXml : CustomAction<CreateCreditNoteXmlConfig>
    {
        StringBuilder _logger = new StringBuilder();
        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var attachment = CreateDocument(args.Context);
                args.Context.CurrentDocument.Attachments.AddNew(attachment);
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

        private NewAttachmentData CreateDocument(ActionContextInfo context)
        {
            _logger.AppendLine("Creating document");
            var creditNoteType = new CreditNoteType();
            var setter = new CreditNoteTypeSet();
            var extensions = SetCollections(setter, creditNoteType, context);
            SetFields(setter, creditNoteType, context, extensions);       
            SetAttachments(creditNoteType, context);
            return SaveToAttachment(creditNoteType);
        }

        private void SetAttachments(CreditNoteType creditNoteType, ActionContextInfo context)
        {
            creditNoteType.AdditionalDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Additional, context);
            creditNoteType.ContractDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Contract, context);
            creditNoteType.DespatchDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Despatch, context);
            creditNoteType.OriginatorDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Originator, context);
            creditNoteType.ReceiptDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Receipt, context);
            creditNoteType.StatementDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Statement, context);
        }

        private XmlHelper.CreditNote.DocumentReferenceType[] SetAttachmentsIfExists(string category, ActionContextInfo context)
        {
            var attachmentsFromCategory = context.CurrentDocument.Attachments.Where(x => string.Equals(x?.FileGroup?.ID, category)).ToList();
            if (attachmentsFromCategory.Count == 0)
                return null;

            return CreateAttachment(attachmentsFromCategory);
        }

        private XmlHelper.CreditNote.DocumentReferenceType[] CreateAttachment(List<AttachmentData> attachmentsFromCategory)
        {
            var attachmentsToAdd = new List<XmlHelper.CreditNote.DocumentReferenceType>();
            foreach (var att in attachmentsFromCategory)
                attachmentsToAdd.Add(new XmlHelper.CreditNote.DocumentReferenceType()
                {
                    Attachment = new XmlHelper.CreditNote.AttachmentType()
                    {
                        EmbeddedDocumentBinaryObject = new XmlHelper.CreditNote.EmbeddedDocumentBinaryObjectType()
                        {
                            filename = att.FileName,
                            mimeCode = MapMimeCode(att.FileExtension.ToLower()),
                            Value = att.Content
                        }
                    }
                });
            return attachmentsToAdd.ToArray();
        }

        private string MapMimeCode(string fileExtension)
        {
            switch (fileExtension)
            {
                case ".csv":
                    return "text/csv";
                case ".pdf":
                    return "application/pdf";
                case ".jpeg":
                    return "image/jpeg";
                case ".png":
                    return "image/png";
                case ".vnd":
                    return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                default:
                    return null;
            }
        }

        private void SetFields(CreditNoteTypeSet setter, CreditNoteType creditNote, ActionContextInfo context, (XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection correction, XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData originalData) extensions)
        {

            _logger.AppendLine("Setting fields");
            var fields = context.CurrentDocument.Fields.Where(x => !string.IsNullOrEmpty(x.Description) && !IsFieldEmpty(x) && !x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase));
            foreach (var field in fields)
            {
                _logger.AppendLine($"Setting field {field.DisplayName}(id: {field.ID}) with path {field.Description} With value: '{field?.GetValue()}'");
                setter.SetField(creditNote, new XmlFieldMapping(field.Description, field));
            }
            _logger.AppendLine("Setting extension fields");
            var extensionFields = context.CurrentDocument.Fields.Where(x => !string.IsNullOrEmpty(x.Description) && !IsFieldEmpty(x) && x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase)).ToList();
             SetExtensionFields(creditNote, extensionFields, extensions);
        }

        private void SetExtensionFields(CreditNoteType creditNote, List<BaseField> extensionFields, (XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection correction, XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData originalData) extensions)
        {
            var setter = new CreditNoteUBLExtensionsTypeSet();
            var groupedExtensionFields = extensionFields.GroupBy(x => GetExtensionRoot(x.Description));
            foreach (var group in groupedExtensionFields)
            {
                _logger.AppendLine($"Setting extensions group {group.Key}");
                switch (group.Key)
                {
                    case "Comment":
                        SetComment(creditNote, setter, group);
                        break;
                    case "InvoiceCorrection":
                        SetInvoiceCorrection(creditNote, setter, group, extensions.correction);
                        break;
                    case "OriginalInvoiceData":
                        SetOriginalInvoiceData(creditNote, setter, group, extensions.originalData);
                        break;
                }
            }
        }

        private void SetOriginalInvoiceData(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeSet setter, IGrouping<string, BaseField> group, XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData originalData)
        {
            foreach (var field in group)
            {
                _logger.AppendLine($"Setting field {field.DisplayName}(id: {field.ID}) with path {field.Description} With value: '{field?.GetValue()}'");
                setter.SetField(originalData, new XmlFieldMapping(GetRelativePath(field.Description, group.Key), field));
            }
            creditNote.UBLExtensions[2] = new XmlHelper.CreditNote.UBLExtensionType()
            {
                ExtensionContent = SerializeToXmlElement(originalData)
            };
        }

        private void SetInvoiceCorrection(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeSet setter, IGrouping<string, BaseField> group, XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection correction)
        {
            foreach (var field in group)
            {
                _logger.AppendLine($"Setting field {field.DisplayName}(id: {field.ID}) with path {field.Description} With value: '{field?.GetValue()}'");
                setter.SetField(correction, new XmlFieldMapping(GetRelativePath(field.Description, group.Key), field));
            }
                
            creditNote.UBLExtensions[1] = new XmlHelper.CreditNote.UBLExtensionType()
            {
                ExtensionContent = SerializeToXmlElement(correction)
            };
        }

        private void SetComment(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeSet setter, IGrouping<string, BaseField> group)
        {
            var comment = new XmlHelper.CreditNoteUBLExtensions.CommentType();
            foreach (var field in group)
            {
                _logger.AppendLine($"Setting field {field.DisplayName}(id: {field.ID}) with path {field.Description} With value: '{field?.GetValue()}'");
                setter.SetField(comment, new XmlFieldMapping(GetRelativePath(field.Description, group.Key), field));
            }          
            creditNote.UBLExtensions[0] = new XmlHelper.CreditNote.UBLExtensionType()
            {
                ExtensionContent = SerializeToXmlElement(comment)
            };
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

        private XmlElement SerializeToXmlElement(object o)
        {
            var doc = new XmlDocument();
            using (var writer = doc.CreateNavigator().AppendChild())
            {
                new XmlSerializer(o.GetType()).Serialize(writer, o);
            }
            doc = RemoveEmpty(doc);          
            return doc.DocumentElement;
        }

        private XmlDocument RemoveEmpty(XmlDocument doc)
        {          
            var xDoc = doc.ToXDocument();
            xDoc.Descendants().Where(e => e.IsEmpty || String.IsNullOrWhiteSpace(e.Value)).Remove();
            return xDoc.ToXmlDocument();
        }

        private bool IsFieldEmpty(BaseField field)
        {
            var value = field.GetValue();
            return value == null || string.IsNullOrEmpty(value.ToString());
        }

        private (XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection correction, XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData originalData) SetCollections(CreditNoteTypeSet setter, CreditNoteType creditNoteType, ActionContextInfo context)
        {
            _logger.AppendLine("setting collections");
            var standardLists = context.CurrentDocument.ItemsLists.Where(x => !string.IsNullOrEmpty(x.Description) && !x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase));
            foreach (var list in standardLists)
            {
                _logger.AppendLine($"Setting list {list.DisplayName} with path {list.Description}");
                var colection = new XmlCollectionMapping(list.Description, list);
                colection.ColumnsMapping = new List<IXmlColumnMapping>();
                foreach (var column in list.Columns)
                    if (!string.IsNullOrEmpty(column.Description))
                    {
                        _logger.AppendLine($"Adding mapping for column {column.DisplayName} with path {column.Description}");
                        var colMaping = new XmlColumnMapping(column.Description, column);
                        colection.ColumnsMapping.Add(colMaping);
                    }
                setter.SetField(creditNoteType, colection);
            }
            var extensionLists = context.CurrentDocument.ItemsLists.Where(x => !string.IsNullOrEmpty(x.Description) && x.Description.StartsWith("UBLExtensions", StringComparison.InvariantCultureIgnoreCase)).ToList();
            return SetExtensionLists(creditNoteType, extensionLists);
        }

        private (XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection correction, XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData originalData) SetExtensionLists(CreditNoteType creditNote, List<ItemsList> extensionFields)
        {
            var correction = new XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection();
            var originalData = new XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData();
            var setter = new CreditNoteUBLExtensionsTypeSet();
            var groupedExtensionFields = extensionFields.GroupBy(x => GetExtensionRoot(x.Description));
            creditNote.UBLExtensions = new XmlHelper.CreditNote.UBLExtensionType[3];
            foreach (var group in groupedExtensionFields)
            {
                switch (group.Key)
                {
                    case "InvoiceCorrection":
                        correction = SetInvoiceCorrectionLists(creditNote, setter, group);
                        break;
                    case "OriginalInvoiceData":
                        originalData = SetOriginalInvoiceDataLists(creditNote, setter, group);
                        break;
                }
            }
            return (correction, originalData);
        }

        private XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData SetOriginalInvoiceDataLists(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeSet setter, IGrouping<string, ItemsList> group)
        {
            var originalData = new XmlHelper.CreditNoteUBLExtensions.OriginalInvoiceData();
            foreach (var list in group)
            {
                var colection = new XmlCollectionMapping(GetRelativePath(list.Description, group.Key), list);
                colection.ColumnsMapping = new List<IXmlColumnMapping>();
                foreach (var column in list.Columns)
                    if (!string.IsNullOrEmpty(column.Description))
                    {
                        _logger.AppendLine($"Adding mapping for column {column.DisplayName} with path {column.Description}");
                        var colMaping = new XmlColumnMapping(column.Description, column);
                        colection.ColumnsMapping.Add(colMaping);
                    }
                setter.SetField(originalData, colection);
            }
            creditNote.UBLExtensions[2] = new XmlHelper.CreditNote.UBLExtensionType()
            {
                ExtensionContent = SerializeToXmlElement(originalData)
            };
            return originalData;
        }

        private XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection SetInvoiceCorrectionLists(CreditNoteType creditNote, CreditNoteUBLExtensionsTypeSet setter, IGrouping<string, ItemsList> group)
        {
            var correction = new XmlHelper.CreditNoteUBLExtensions.InvoiceCorrection();
            foreach (var list in group)
            {
                var colection = new XmlCollectionMapping(GetRelativePath(list.Description, group.Key), list);
                colection.ColumnsMapping = new List<IXmlColumnMapping>();
                foreach (var column in list.Columns)
                    if (!string.IsNullOrEmpty(column.Description))
                    {
                        _logger.AppendLine($"Adding mapping for column {column.DisplayName} with path {column.Description}");
                        var colMaping = new XmlColumnMapping(column.Description, column);
                        colection.ColumnsMapping.Add(colMaping);
                    }
                setter.SetField(correction, colection);
            }
            creditNote.UBLExtensions[1] = new XmlHelper.CreditNote.UBLExtensionType()
            {
                ExtensionContent = SerializeToXmlElement(correction)
            };
            return correction;
        }

        private NewAttachmentData SaveToAttachment(CreditNoteType invoiceType)
        {
            _logger.AppendLine("Creating attachment");
            var serializer = new XmlSerializer(typeof(CreditNoteType));
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            namespaces.Add("ns2", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
            namespaces.Add("ns5", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
            namespaces.Add("ns6", "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2");
            namespaces.Add("ns3", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            namespaces.Add("ns4", "urn:oasis:names:specification:ubl:schema:xsd:Order-2");
            namespaces.Add("ns11", "urn:pl:extended:CommonAggregateComponents-2");
            namespaces.Add("ns9", "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2");
            namespaces.Add("ns10", "urn:pl:extended:CommonBasicComponents-2");
            namespaces.Add("ns7", "urn:oasis:names:specification:ubl:schema:xsd:ReceiptAdvice-2");
            namespaces.Add("ns8", "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2");
            var settings = new XmlWriterSettings { Encoding = new UTF8Encoding(true) };
            using (var stream = new MemoryStream())
            {
                using (var writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, invoiceType, namespaces);
                    var doc = RemoveEmptyNodes(stream);
                    using (var saveStream = new MemoryStream())
                    {
                        doc.Save(saveStream);
                        var content = saveStream.ToArray();
                        return CreateAttachment(content);
                    }
                }
            }
        }

        private XDocument RemoveEmptyNodes(MemoryStream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            var doc = XDocument.Load(stream);
            if (Configuration.RemoveEmptyNodes)
                doc.Descendants().Where(e => e.IsEmpty || String.IsNullOrWhiteSpace(e.Value)).Remove();
            return doc;
        }

        private NewAttachmentData CreateAttachment(byte[] content)
        {
            var att = new NewAttachmentData(GetAttachmentName(), content);
            if (!string.IsNullOrEmpty(Configuration.AttachmentCategory))
                att.FileGroup = new AttachmentsGroup(TextHelper.GetPairId(Configuration.AttachmentCategory),
                    TextHelper.GetPairName(Configuration.AttachmentCategory));

            return att;
        }

        private string GetAttachmentName()
        {
            return Configuration.AttachmentName.EndsWith(".xml") ? Configuration.AttachmentName : $"{Configuration.AttachmentName}.xml";
        }
    }
}