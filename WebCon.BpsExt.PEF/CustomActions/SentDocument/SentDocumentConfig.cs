using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.SentDocument
{
    public class SentDocumentConfig : PluginConfiguration
    {
        [ConfigEditableConnectionID(DisplayName = "Connection to PEF", IsRequired = true)]
        public int ConnectionID { get; set; }

        [ConfigEditableText(DisplayName = "Document type", IsRequired = true, Description = "Available values: CREDIT_NOTE, DESPATCH_ADVICE, INVOICE, INVOICE_CORRECTION, ORDER, RECEIPT_ADVICE")]
        public string DocumentType { get; set; }

        [ConfigEditableText(DisplayName = "SQL query for attachment", Description = "SQL query returning the id of the attachment to be sent", IsRequired = true, TagEvaluationMode = EvaluationMode.SQL)]
        public string Query { get; set; }

        [ConfigEditableFormFieldID("Field for documentId")]
        public int? DocumentIdFieldId { get; set; }
    }
}