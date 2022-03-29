using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WebCon.BpsExt.PEF.CustomActions.Models;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;
using WebCon.WorkFlow.SDK.Tools.Data.Model;
using WebCon.WorkFlow.SDK.Tools.Other;
using System.Linq;
using WebCon.WorkFlow.SDK.Documents.Model.Fields;
using System.Xml.Linq;
using WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping;

namespace WebCon.BpsExt.PEF.CustomActions.CreateXml
{
    public class CreateXml : CustomAction<CreateXmlConfig>
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
            var invoiceType = new InvoiceType();
            var setter = new InvoiceTypeSet();
            SetFields(setter, invoiceType, context);
            SetCollections(setter, invoiceType, context);
            SetAttachments(invoiceType, context);
            return SaveToAttachment(invoiceType);
        }

        private void SetAttachments(InvoiceType invoiceType, ActionContextInfo context)
        {
            invoiceType.AdditionalDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Additional, context);
            invoiceType.ContractDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Contract, context);
            invoiceType.DespatchDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Despatch, context);
            invoiceType.OriginatorDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Originator, context);
            invoiceType.ReceiptDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Receipt, context);
            invoiceType.StatementDocumentReference = SetAttachmentsIfExists(AttachmentsCategory.Statement, context);
        }

        private DocumentReferenceType[] SetAttachmentsIfExists(string category, ActionContextInfo context)
        {
            var attachmentsFromCategory = context.CurrentDocument.Attachments.Where(x => string.Equals(x?.FileGroup?.ID, category)).ToList();
            if (attachmentsFromCategory.Count == 0)
                return null;
           
            return CreateAttachment(attachmentsFromCategory);
        }

        private DocumentReferenceType[] CreateAttachment(List<AttachmentData> attachmentsFromCategory)
        {
            var attachmentsToAdd = new List<DocumentReferenceType>();
            foreach (var att in attachmentsFromCategory)
                attachmentsToAdd.Add(new DocumentReferenceType()
                {
                    Attachment = new AttachmentType()
                    {
                        EmbeddedDocumentBinaryObject = new EmbeddedDocumentBinaryObjectType()
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

        private void SetFields(InvoiceTypeSet setter, InvoiceType invoiceType, ActionContextInfo context)
        {

            _logger.AppendLine("Setting fields");
            var fields = context.CurrentDocument.Fields.Where(x => !string.IsNullOrEmpty(x.Description) && !IsFieldEmpty(x));
            foreach (var field in fields)
            {
                _logger.AppendLine($"Setting field {field.DisplayName}(id: {field.ID}) with path {field.Description} With value: '{field?.GetValue()}'");
                setter.SetField(invoiceType, new XmlFieldMapping(field.Description, field));
            }

        }

        private bool IsFieldEmpty(BaseField field)
        {
            var value = field.GetValue();
            return value == null || string.IsNullOrEmpty(value.ToString());
        }

        private void SetCollections(InvoiceTypeSet setter, InvoiceType invoiceType, ActionContextInfo context)
        {
            _logger.AppendLine("setting collections");
            foreach (var list in context.CurrentDocument.ItemsLists)
                if (!string.IsNullOrEmpty(list.Description))
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
                    setter.SetField(invoiceType, colection);
                }
        }

        private NewAttachmentData SaveToAttachment(InvoiceType invoiceType)
        {
            _logger.AppendLine("Creating attachment");
            var serializer = new XmlSerializer(typeof(InvoiceType));
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
            namespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
            namespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
            namespaces.Add("ccts", "urn:un:unece:uncefact:documentation:2");
            namespaces.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
            namespaces.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
            namespaces.Add("xs", "http://www.w3.org/2001/XMLSchema");
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
            if(Configuration.RemoveEmptyNodes)
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