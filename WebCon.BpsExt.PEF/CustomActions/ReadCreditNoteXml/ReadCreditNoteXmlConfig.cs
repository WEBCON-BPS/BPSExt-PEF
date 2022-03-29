using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.ReadCreditNoteXml
{
    public class ReadCreditNoteXmlConfig : PluginConfiguration
    {
        [ConfigEditableText(DisplayName = "Id of category with attachments", Description = "Id of category from which the attachment will be downloaded")]
        public string CategoryId { get; set; }
    }
}