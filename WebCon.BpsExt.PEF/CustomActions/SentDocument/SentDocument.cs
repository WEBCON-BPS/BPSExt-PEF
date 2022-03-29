using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text;
using System.Xml;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;

namespace WebCon.BpsExt.PEF.CustomActions.SentDocument
{
    public class SentDocument : CustomAction<SentDocumentConfig>
    {
        StringBuilder _logger = new StringBuilder();
        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var apiHelper = new SentDocumentApiHelper(Configuration, args.Context, _logger);
                var att = GetAttachment(args.Context);
                var content = GetStringContent(att);
                var result  = apiHelper.SendDocument(content);
                if (result != null)
                    SaveDocumentId(result, args.Context);
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

        private void SaveDocumentId(string result, ActionContextInfo context)
        {
            var documentId = JObject.Parse(result).Value<string>("documentId");
            if (Configuration.DocumentIdFieldId.HasValue)
                context.CurrentDocument.Fields.GetByID(Configuration.DocumentIdFieldId.Value).SetValue(documentId);
        }

        private string GetStringContent(AttachmentData att)
        {
            _logger.AppendLine("Processing xml document");
            var xmlDoc = new XmlDocument();
            using (var stream = new MemoryStream(att.Content))
            {
                xmlDoc.Load(stream);
                return xmlDoc.OuterXml;
            }
        }

        private AttachmentData GetAttachment(ActionContextInfo context)
        {
            _logger.AppendLine("Executing sql query for attachment id");
            var attId = WebCon.WorkFlow.SDK.Tools.Data.SqlExecutionHelper.ExecSqlCommandScalar(Configuration.Query, context);
            _logger.AppendLine($"Downloadning attachment of id: {attId}");
            return new DocumentAttachmentsManager(context).GetAttachment((int)attId, true);
        }
    }
}