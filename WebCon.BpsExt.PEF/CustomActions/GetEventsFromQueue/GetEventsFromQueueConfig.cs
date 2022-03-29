using System.Collections.Generic;
using WebCon.BpsExt.PEF.CustomActions.Models;
using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.GetEventsFromQueue
{
    public class GetEventsFromQueueConfig : PluginConfiguration
    {
       [ConfigEditableConnectionID(DisplayName = "Connection to PEF", IsRequired = true)]
        public int ConnectionID { get; set; }

        [ConfigGroupBox(DisplayName = "Configuration for DocumentReceivedMessgae")]
        public DocumentReceivedConfiguration DocumentReceivedConfig { get; set; }

        [ConfigGroupBox(DisplayName = "Configuration for StatusChangedMessgae")]
        public ReceivedAndSentDocumentStatusChangedConfiguration RecivedAndSentStatusChangedConfig { get; set; }

        [ConfigGroupBox(DisplayName = "Configuration for SentDocumentErrorMessgae")]
        public SentDocumentErrorConfiguration SentDocumentErrorConfiguration { get; set; }

        [ConfigEditableInteger(DisplayName = "Maximum number of executions", IsRequired = true, DefaultValue = 10)]
        public int MaxElementsToProcess { get; set; }

        [ConfigEditableInteger(DisplayName = "Maximum execution time in seconds", IsRequired = true, DefaultValue = 110, MinValue = 1)]
        public int MaxExecutionTime { get; set; }

    }


    public class ReceivedAndSentDocumentStatusChangedConfiguration
    {
        [ConfigEditableDataSourceID(DisplayName = "Datasource with documents", Description ="Źródło zwracajace dwie kolumny, w pierwszej id elementu w drugiej wartośc pola z documentId")]
        public int DataSourceId { get; set; }

        [ConfigEditableText(DisplayName = "Attachment category", Description = "Category to which the attachment will be added. Category format: id#name")]
        public string AttCategory { get; set; }

        [ConfigEditableFormFieldID("Field with document status")]
        public int? StatusFieldId { get; set; }
    }

    public class SentDocumentErrorConfiguration
    {
        [ConfigEditableItemList(DisplayName = "Items list for errors")]
        public ErrorsList ErrorsList { get; set; }
    }

    public class DocumentReceivedConfiguration
    {
        [ConfigEditableFormFieldID(DisplayName = "Field for documentId", Description = "Atrybut w którym zostanie zapisane wartość documentId zwrócona przez API")]
        public int DocumentIdFieldId { get; set; }

        [ConfigEditableFormFieldID("Field with messageId")]
        public int? MessageIdFieldId { get; set; }

        [ConfigEditableFormFieldID("Field with documentType")]
        public int? DocumentTypeFieldId { get; set; }

        [ConfigEditableFormFieldID("Field with messageType")]
        public int? MessageTypeFieldId { get; set; }

        [ConfigEditableFormFieldID(DisplayName = "Field for validation date")]
        public int VallidationDateFieldId { get; set; }

        [ConfigEditableItemList(DisplayName = "Items list for validation", Description = "Items list to which warnings returned from validation will be saved")]
        public WarningsList WarningsList { get; set; }

        [ConfigEditableText("Form type", "Id of document type from BPS to start")]
        public int FormTypeId { get; set; }

        [ConfigEditableText(DisplayName = "Start path", Description = "The path to start the documents")]
        public int StartPathId { get; set; }

        [ConfigEditableText(DisplayName = "WorkFlow Id")]
        public int WorkFlowId { get; set; }
    }

    public class WarningsList : IConfigEditableItemList
    {
        public int ItemListId { get; set; }
        
        [ConfigEditableItemListColumnID(DisplayName = "Column with warning")]
        public int WarningColumnId { get; set; }
    }

    public class ErrorsList : IConfigEditableItemList
    {
        public int ItemListId { get; set; }

        [ConfigEditableItemListColumnID(DisplayName = "Column for error code")]
        public int ErrorCodeColumnId { get; set; }

        [ConfigEditableItemListColumnID(DisplayName = "Column for error description")]
        public int ErrorDescColumnId { get; set; }
    }
}