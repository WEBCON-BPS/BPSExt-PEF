using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using WebCon.WorkFlow.SDK.Tools.Other;
using WebCon.BpsExt.PEF.CustomActions.Models;

namespace WebCon.BpsExt.PEF.CustomActions.ReadXml
{
    public class ReadXml : CustomAction<ReadXmlConfig>
    {
        StringBuilder _logger = new StringBuilder();
        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var att = GetAttachment(args.Context);
                if(att != null)
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
            var invoice = GetInvoice(xml);         
            var getter = new InvoiceTypeGet();
            GetAttachmentsFromXml(invoice, context);
            SetFields(invoice, getter, context);
            SetCollections(invoice, getter, context);         
        }

        private void GetAttachmentsFromXml(InvoiceType invoice, ActionContextInfo context)
        {
            _logger.AppendLine("Getting attachments from xml");
            GetAttachments(context, new Attachments(invoice.AdditionalDocumentReference, AttachmentsCategory.Additional),
                new Attachments(invoice.ContractDocumentReference, AttachmentsCategory.Contract),
                new Attachments(invoice.DespatchDocumentReference, AttachmentsCategory.Despatch),
                new Attachments(invoice.OriginatorDocumentReference, AttachmentsCategory.Originator),
                new Attachments(invoice.ReceiptDocumentReference, AttachmentsCategory.Receipt),
                new Attachments(invoice.StatementDocumentReference, AttachmentsCategory.Statement));
        }

        private void GetAttachments(ActionContextInfo context, params Attachments[] documents)
        {
            foreach (var documentType in documents ?? Enumerable.Empty<Attachments>())
                foreach (var document in documentType.Documents ?? Enumerable.Empty<DocumentReferenceType>())
                    GetAttachment(document, documentType.Category, context);
        }

        private void GetAttachment(DocumentReferenceType document, string category, ActionContextInfo context)
        {
            if (document?.Attachment?.EmbeddedDocumentBinaryObject != null)
                AddBinaryFile(document.Attachment.EmbeddedDocumentBinaryObject, category, context);
            if (document?.Attachment?.ExternalReference != null)
                AddUrlFile(document.Attachment.ExternalReference, category, context);
        }
        private void AddBinaryFile(EmbeddedDocumentBinaryObjectType attachment, string category, ActionContextInfo context)
        {
            var att = new NewAttachmentData(attachment.filename, attachment.Value);
            AddAttachmentToCategory(att, category, context);
        }
        private void AddUrlFile(ExternalReferenceType attachment, string category, ActionContextInfo context)
        {
            using(var client = new HttpClient())
            {
                var response = client.GetAsync(attachment.URI.Value).Result;
                using(var stream = new MemoryStream())
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

        private void SetCollections(InvoiceType invoice, InvoiceTypeGet getter, ActionContextInfo context)
        {
            _logger.AppendLine("Getting collestions from xml");
            foreach (var list in context.CurrentDocument.ItemsLists)
                if (!string.IsNullOrEmpty(list.Description))
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
                    getter.GetField(invoice, colection);
                }
        }

        private void SetFields(InvoiceType invoice, InvoiceTypeGet getter, ActionContextInfo context)
        {
            _logger.AppendLine("Getting fields from xml");
            foreach (var field in context.CurrentDocument.Fields)
                if (!string.IsNullOrEmpty(field.Description))
                {
                    _logger.AppendLine($"Getting field {field.DisplayName} with xpath {field.Description}");
                    getter.GetField(invoice, new XmlFieldMapping(field.Description, field));
                }                  
        }

        private InvoiceType GetInvoice(string xml)
        {
            _logger.AppendLine("Creating invoice object");
            var invoiceType = new InvoiceType();
            var serializer = new XmlSerializer(typeof(InvoiceType));
            using (var reader = new StringReader(xml))
            {
                invoiceType = (InvoiceType)serializer.Deserialize(reader);
                return invoiceType;
            }
        }

        private string GetXml(AttachmentData att)
        {
            _logger.AppendLine("Loading xml");
            var doc = new XmlDocument();
            using(var stream = new MemoryStream(att.Content))
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
    }
}