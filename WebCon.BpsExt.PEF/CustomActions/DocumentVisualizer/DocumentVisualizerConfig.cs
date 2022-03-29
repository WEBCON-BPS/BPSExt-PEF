using WebCon.WorkFlow.SDK.Common;
using WebCon.WorkFlow.SDK.ConfigAttributes;

namespace WebCon.BpsExt.PEF.CustomActions.DocumentVisualizer
{
    public class DocumentVisualizerConfig : PluginConfiguration
    {
        [ConfigEditableText("ID(guid) of element with zip")]
        public string ZipElementGuid { get; set; }

        [ConfigEditableText("Id of category for generated visualization")]
        public string HtmlAttachmentCategoryId { get; set; }

        [ConfigEditableText("Id of category with xml")]
        public string CategoryId { get; set; }

        [ConfigEditableEnum("Visualization file type")]
        public OutputFileType FileType { get; set; }
    }

    public enum OutputFileType
    {
        pdf = 0,
        html = 1
    }
}