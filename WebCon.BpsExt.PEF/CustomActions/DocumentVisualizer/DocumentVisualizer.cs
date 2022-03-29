using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.WorkFlow.SDK.Documents.Model.Attachments;

namespace WebCon.BpsExt.PEF.CustomActions.DocumentVisualizer
{
    public class DocumentVisualizer : CustomAction<DocumentVisualizerConfig>
    {
        StringBuilder _logger = new StringBuilder();

        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var att = GetZip(args.Context);
                AddVisualization(att, args);
            }
            catch (Exception ex)
            {
                args.HasErrors = true;
                args.Message = ex.Message;
                _logger.AppendLine(ex.ToString());
            }
            finally
            {
                args.LogMessage = _logger.ToString();
                args.Context.PluginLogger.AppendInfo(_logger.ToString());
            }
        }

        private void AddVisualization(AttachmentData att, RunCustomActionParams args)
        {
            var xml = GetXml(args, out var fileName);
            if (xml != null)
            {
                var xslPath = GetFilesFromZip(att, args.Context);
                AddHtml(args.Context, xslPath, xml, fileName);
                Directory.Delete(Path.GetDirectoryName(xslPath), true);
            }
        }

        private void AddHtml(ActionContextInfo context, string xslPath, string xml, string fileName)
        {
            var html = TransformXMLToHTML(xml, xslPath);
            AddPdfToAttachments(html, fileName, context);
        }

        private void AddPdfToAttachments(string html, string fileName, ActionContextInfo context)
        {
            var fileContent = GetFileContent(html, context, out var extension);
            var att = new NewAttachmentData($"{Path.GetFileNameWithoutExtension(fileName)}.{extension}", fileContent);
            att.SetFileGroup(Configuration.HtmlAttachmentCategoryId);
            context.CurrentDocument.Attachments.AddNew(att);
        }

        private byte[] GetFileContent(string html, ActionContextInfo context, out string extension)
        {
            extension = "html";
            if (Configuration.FileType == OutputFileType.html)
                return Encoding.UTF8.GetBytes(html);
            else
            {
                extension = "pdf";
                var parms = new WorkFlow.SDK.Tools.Files.GeneratePdfParams() { HtmlTemplateContent = html, Document = context.CurrentDocument };
                return new WebCon.WorkFlow.SDK.Tools.Files.FileGenerationHelper(context).GeneratePdf(parms);
            }
        }

        private string GetXml(RunCustomActionParams args, out string fileName)
        {
            fileName = null;
            var att = args.Context.CurrentDocument.Attachments.Where(x => x.FileGroup?.ID == Configuration.CategoryId)?.OrderBy( x => x.ID)?.LastOrDefault();
            if(att != null)
            {
                fileName = att.FileName;
                using (var stream = new MemoryStream(att.Content))
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            SetHasError($"There is no attachment in category of id: {Configuration.CategoryId}", args);
            return null;       
        }

        private void SetHasError(string message, RunCustomActionParams args)
        {
            _logger.AppendLine(message);
            args.Message = message;
            args.HasErrors = true;
        }

        private string TransformXMLToHTML(string inputXml, string xslName)
        {
            var settings = new XsltSettings(true, true);
            var resolver = new XmlUrlResolver();
            var transform = new XslCompiledTransform();
            var xmlSetting = new XmlReaderSettings();
            xmlSetting.DtdProcessing = DtdProcessing.Parse;
            transform.Load(xslName, settings, resolver);
            var results = new StringWriter();
            using (var reader = XmlReader.Create(new StringReader(inputXml), xmlSetting))
                transform.Transform(reader, null, results);

            return results.ToString();
        }

        private string GetFilesFromZip(AttachmentData att, ActionContextInfo context)
        {           
            using (var stream = new MemoryStream(att.Content))
            using (var zip = new ZipArchive(stream))
            {
                var path = $"{Path.GetTempPath()}{context.CurrentDocument.ID}";
                CreateNewDirectory(path);
                foreach (var entry in zip.Entries)
                    entry.ExtractToFile($"{path}\\{entry.Name}");
                return $"{path}\\{zip.Entries.First(x => x.Name.EndsWith(".xsl")).Name}";
            }               
        }

        private AttachmentData GetZip(ActionContextInfo context)
        {
            var id = WebCon.WorkFlow.SDK.Tools.Data.SqlExecutionHelper.ExecSqlCommandScalar($"SELECT WFD_ID FROM WFElements WHERE WFD_Guid = '{Configuration.ZipElementGuid}'", context);
            return new WebCon.WorkFlow.SDK.Documents.DocumentsManager(context).GetDocumentByID((int)id, true).Attachments.First();
        }

        private void CreateNewDirectory(string path)
        {
            if(Directory.Exists(path))
                Directory.Delete(path, true);

            Directory.CreateDirectory(path);
        }
    }
}