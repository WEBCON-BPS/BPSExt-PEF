using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.DownloadDocument
{
    public class DownloadDocumentConfig : PluginConfiguration
    {
        [ConfigEditableConnectionID(DisplayName = "Connection to PEF", IsRequired = true)]
        public int ConnectionID { get; set; }

        [ConfigEditableText(DisplayName = "Document to download Id", IsRequired = true)]
        public string DocumentId { get; set; }

        [ConfigEditableText(DisplayName = "Document type", IsRequired = true, Description = "Available values: CREDIT_NOTE, DESPATCH_ADVICE, INVOICE, INVOICE_CORRECTION, ORDER, RECEIPT_ADVICE")]
        public string DocumentType { get; set; }

        [ConfigEditableText(DisplayName = "Attachment category", Description = "Category to which the attachment will be added. Category format: id#name")]
        public string AttCategory { get; set; }
    }
}