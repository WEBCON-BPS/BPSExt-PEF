using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.CreateXml
{
    public class CreateXmlConfig : PluginConfiguration
    {
        [ConfigEditableText(DisplayName = "Xml attachment name")]
        public string AttachmentName { get; set; }

        [ConfigEditableText(DisplayName = "Attachment category", Description = "id#name format")]
        public string AttachmentCategory { get; set; }

        [ConfigEditableBool("Remove empty nodes", DefaultValue = true)]
        public bool RemoveEmptyNodes { get; set; }
    }
}