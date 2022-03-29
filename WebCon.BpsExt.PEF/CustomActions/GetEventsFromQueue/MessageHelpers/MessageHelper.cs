using System;
using System.Collections.Generic;
using System.Text;
using WebCon.BpsExt.PEF.CustomActions.Models;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model;
using WebCon.WorkFlow.SDK.Documents;
using WebCon.WorkFlow.SDK.Common.Model;
using WebCon.WorkFlow.SDK.Tools.Data.Model;
using WebCon.WorkFlow.SDK.Tools.Data;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;
using WebCon.WorkFlow.SDK.Tools.Other;
using System.Data;

namespace WebCon.BpsExt.PEF.CustomActions.GetEventsFromQueue.MessageHelpers
{
    public class MessageHelper
    {

        private GetEventsFromQueueConfig _config;
        private ActionWithoutDocumentContext _context;
        private StringBuilder _logger;
        private QueueApiHelper _apiHelper;

        public MessageHelper(GetEventsFromQueueConfig config, ActionWithoutDocumentContext context, StringBuilder logger, QueueApiHelper apiHelper)
        {
            _config = config;
            _context = context;
            _logger = logger;
            _apiHelper = apiHelper;
        }

        public void ProcessDocumentReceivedMessage(StartNewDocumentMessage message, string messageType)
        {
            _logger.AppendLine("Processing DocumentReceivedMessage");
            if (!DocumentExsistsWithValidMessage(message.DocumentId, message.MessageId, out int wfdId) && wfdId == -1)
            {
                StartDocument(message, messageType);
                _apiHelper.DeleteMessage(message.MessageId);
            }       
        }

        public void ProcessReceivedOrSentDocumentStatusChangedMessage(ReceivedOrSendDocumentStatusChangedMessage message, string messageType, string rawMessage)
        {
            _logger.AppendLine("Processing ReceivedOrSentDocumentStatusChangedMessage");
            if (DocumentExsistsWithValidMessage(message.DocumentId, message.MessageId, out int wfdId))
            {
                var manager = new DocumentsManager(_context);
                var document = manager.GetDocumentByID(wfdId, true);
                SetStatusChangedFields(document, message, messageType);
                AddAttachment(document, message.Status, rawMessage);
                manager.UpdateDocument(new UpdateDocumentParams(document) { SkipPermissionsCheck = true }); ;
                _apiHelper.DeleteMessage(message.MessageId);
            }
            else if (wfdId == -1)
                StartDocument(message, messageType);
        }

        public void ProcessSentDocumentErrorMessage(SentDocumentErrorMessage message, string messageType)
        {           
            _logger.AppendLine("Processing SentDocumentErrorMessage");
            if (DocumentExsistsWithValidMessage(message.DocumentId, message.MessageId, out int wfdId))
            {
                SaveErors(wfdId, message, messageType);
                _apiHelper.DeleteMessage(message.MessageId);
            }
            else if (wfdId == -1)
                StartSentDocumentErrorMessage(message, messageType);
        }

        public void StartSentDocumentErrorMessage(SentDocumentErrorMessage message, string messageType)
        {
            _logger.AppendLine("Starting document");
            var manager = new DocumentsManager(_context);
            var document = manager.GetNewDocument(new GetNewDocumentParams(_config.DocumentReceivedConfig.FormTypeId, _config.DocumentReceivedConfig.WorkFlowId) { SkipPermissionsCheck = true });
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.DocumentIdFieldId, message.DocumentId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageIdFieldId, message.MessageId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageTypeFieldId, messageType);
            var startedDocumentResult = manager.StartNewWorkFlow(new StartNewWorkFlowParams(document, _config.DocumentReceivedConfig.StartPathId) { SkipPermissionsCheck = true });
            SaveErors(startedDocumentResult.CreatedDocumentID, message, messageType);
            _apiHelper.DeleteMessage(message.MessageId);
        }

        private void SaveErors(int documentId, SentDocumentErrorMessage message, string messageType)
        {
            _logger.AppendLine("Saving errors");
            var manager = new DocumentsManager(_context);
            var listConfig = _config.SentDocumentErrorConfiguration.ErrorsList;
            var document = manager.GetDocumentByID(documentId, true);
            var errorsList = document.ItemsLists.GetByID(listConfig.ItemListId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageIdFieldId, message.MessageId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageTypeFieldId, messageType);
            foreach (var error in message.Errors)
            {
                var row = errorsList.Rows.AddNewRow();
                row.SetCellValue(listConfig.ErrorCodeColumnId, error.ErrorCode);
                row.SetCellValue(listConfig.ErrorDescColumnId, error.ErrorMessage);
            }
            manager.UpdateDocument(new UpdateDocumentParams(document) { SkipPermissionsCheck = true});         
        }

        private void AddAttachment(ExistingDocumentData document, string status, string message)
        {
            _logger.AppendLine("Adding attachment");
            var att = new NewAttachmentData($"{status}.txt", Encoding.UTF8.GetBytes(message));
            var category = _config.RecivedAndSentStatusChangedConfig.AttCategory;
            att.FileGroup = new AttachmentsGroup(TextHelper.GetPairId(category), TextHelper.GetPairName(category));
            document.Attachments.AddNew(att);
        }

        public bool IsMessageAlreadyProcessed(string documentId, string messageId, DataTable dt)
        {
            if (dt.Rows.Count != 0)
                if (string.Equals(dt.Rows[0]["documentId"].ToString(), documentId, StringComparison.InvariantCultureIgnoreCase) &&
                    string.Equals(dt.Rows[0]["messageId"].ToString(), messageId, StringComparison.InvariantCultureIgnoreCase))
                    return true;

            return false;
        }


        private bool DocumentExsistsWithValidMessage(string documentId, string messageId, out int wfdId)
        {
            var dt = GetTableWithIds(documentId);
            if(TryGetWfdId(documentId, dt,  out wfdId))
            {
                if(IsMessageAlreadyProcessed(documentId, messageId, dt))
                {
                    _logger.AppendLine($"Message with id {messageId} for document {documentId} has already been processed. Deleting message.");
                    _apiHelper.DeleteMessage(messageId);
                    return false;
                }
                return true;
            }
            return false;
        }

        private bool TryGetWfdId(string documentId, DataTable dt,  out int wfdId)
        {
            wfdId = -1;
            if (dt.Rows.Count > 1)
            {
                _logger.AppendLine($"There is more than one document with id {documentId}");
                wfdId = -2;
            }
            else if (dt.Rows.Count < 1)
                _logger.AppendLine($"There is no document with id {documentId}");
            else if (dt.Rows.Count == 1)
            {
                wfdId = (int)dt.Rows[0][0];
                return true;
            }
            return false;
        }

        private DataTable GetTableWithIds(string documentId)
        {
            _logger.AppendLine("Downloading Datasource with documents id");
            var conditions = new SearchConditions();
            conditions.OrConditions.Add(new SearchCondition("documentId", documentId, MatchType.Equals));
            var parms = new GetDataTableFromDataSourceParams(_config.RecivedAndSentStatusChangedConfig.DataSourceId, _context)
            {
                Conditions = conditions
            };
            return DataSourcesHelper.GetDataTableFromDataSource(parms);
        }

        private void StartDocument(StartNewDocumentMessage message, string messageType)
        {
            _logger.AppendLine("Starting document");
            var manager = new DocumentsManager(_context);
            var document = manager.GetNewDocument(new GetNewDocumentParams(_config.DocumentReceivedConfig.FormTypeId, _config.DocumentReceivedConfig.WorkFlowId) { SkipPermissionsCheck = true });
            SetStartDocumentFields(document, message, messageType);
            if (message is DocumentReceivedMessage)
                AddBusinessValidationReport(message as DocumentReceivedMessage, document);

            manager.StartNewWorkFlow(new StartNewWorkFlowParams(document, _config.DocumentReceivedConfig.StartPathId) { SkipPermissionsCheck = true });
        }

        private void StartDocument(ReceivedOrSendDocumentStatusChangedMessage message, string messageType)
        {
            _logger.AppendLine("Starting document");
            var manager = new DocumentsManager(_context);
            var document = manager.GetNewDocument(new GetNewDocumentParams(_config.DocumentReceivedConfig.FormTypeId, _config.DocumentReceivedConfig.WorkFlowId) { SkipPermissionsCheck = true });
            SetStatusChangedFields(document, message, messageType);
            manager.StartNewWorkFlow(new StartNewWorkFlowParams(document, _config.DocumentReceivedConfig.StartPathId) { SkipPermissionsCheck = true });
            _apiHelper.DeleteMessage(message.MessageId);
        }

        private void AddBusinessValidationReport(DocumentReceivedMessage message, NewDocumentData document)
        {
            _logger.AppendLine("Adding BusinessValidationReport");
            document.SetFieldValue(_config.DocumentReceivedConfig.VallidationDateFieldId, message.BusinessValidationReport?.ReportDate);
            if (message.BusinessValidationReport?.Warnings.Count > 0)
            {
                var list = document.ItemsLists.GetByID(_config.DocumentReceivedConfig.WarningsList.ItemListId);
                foreach (var warning in message.BusinessValidationReport.Warnings)
                {
                    var row = list.Rows.AddNewRow();
                    row.SetCellValue(_config.DocumentReceivedConfig.WarningsList.WarningColumnId, warning);
                }            
            }
        }

        private void SetStartDocumentFields(NewDocumentData document, StartNewDocumentMessage message, string messageType)
        {
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.DocumentIdFieldId, message.DocumentId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageIdFieldId, message.MessageId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.DocumentTypeFieldId, message.DocumentType);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageTypeFieldId, messageType);
        }

        private void SetStatusChangedFields(NewDocumentData document, ReceivedOrSendDocumentStatusChangedMessage message, string messageType)
        {
            SetFieldIfDefined(document, _config.RecivedAndSentStatusChangedConfig.StatusFieldId, message.Status);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageIdFieldId, message.MessageId);
            SetFieldIfDefined(document, _config.DocumentReceivedConfig.MessageTypeFieldId, messageType);
            if(document is NewDocumentData)
                SetFieldIfDefined(document, _config.DocumentReceivedConfig.DocumentIdFieldId, message.DocumentId);
        }

        private void SetFieldIfDefined(NewDocumentData document, int? id, object value)
        {
            if(id.HasValue)
                document.Fields.GetByID(id.Value).SetValue(value);
        }
    }
}
