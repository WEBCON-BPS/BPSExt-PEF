using System;
using System.IO;
using System.Text;
using System.Xml;
using WebCon.BpsExt.PEF.CustomActions.GetEventsFromQueue;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;
using WebCon.WorkFlow.SDK.Tools.Other;

namespace WebCon.BpsExt.PEF.CustomActions.DownloadDocument
{
    public class DownloadDocument : CustomAction<DownloadDocumentConfig>
    {
        StringBuilder _logger = new StringBuilder();
        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var apiHelper = new DownloadApiHelper(Configuration, args.Context, _logger);
                var document = apiHelper.DownloadDocument(Configuration.DocumentId, Configuration.DocumentType);
                if (!string.IsNullOrEmpty(document))
                    AddDocumentAsAttachment(document, args.Context);
                else
                    SetErrorMessage(args);
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

        private void SetErrorMessage(RunCustomActionParams args)
        {
            args.Message = "Document downloading failed. More informaction in action log";
            args.HasErrors = true;
        }

        private void AddDocumentAsAttachment(string document, ActionContextInfo context)
        {   
            var content = GetContentAsXmlDocument(document);
            _logger.AppendLine("Adding xml to attachments");
            var att = new NewAttachmentData($"{Configuration.DocumentType}.xml", content);
            att.FileGroup = new AttachmentsGroup(TextHelper.GetPairId(Configuration.AttCategory), TextHelper.GetPairName(Configuration.AttCategory));
            context.CurrentDocument.Attachments.AddNew(att);
        }

        private byte[] GetContentAsXmlDocument(string document)
        {
            _logger.AppendLine("Processing xml document");
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(document);
            using(var stream = new MemoryStream())
            {
                xmlDoc.Save(stream);
                return stream.ToArray();
            }        
        }
    }
}