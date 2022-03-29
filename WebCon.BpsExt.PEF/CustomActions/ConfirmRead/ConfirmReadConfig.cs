using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.ConfirmRead
{
    public class ConfirmReadConfig : PluginConfiguration
    {
        [ConfigEditableConnectionID(DisplayName = "Connection to PEF", IsRequired = true)]
        public int ConnectionID { get; set; }

        [ConfigEditableText(DisplayName = "Document Id", IsRequired = true, Description = "Id of the document to confirmed")]
        public string DocumentId { get; set; }
    }
}