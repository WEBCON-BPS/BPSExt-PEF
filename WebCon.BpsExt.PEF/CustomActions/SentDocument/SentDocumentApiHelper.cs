using System.Net.Http;
using System.Text;
using WebCon.WorkFlow.SDK.Common.Model;

namespace WebCon.BpsExt.PEF.CustomActions.SentDocument
{
    public class SentDocumentApiHelper : ApiHelperBase.ApiHelperBase
    {
        private const string SendDocumentEnpoint = "/api/v1/documents";
        private SentDocumentConfig _config;

        public SentDocumentApiHelper(SentDocumentConfig config, BaseContext context, StringBuilder logger) : base(config.ConnectionID, context, logger) {
            _config = config;
        }

        public string SendDocument(string content)
        {
            _logger.AppendLine("Sending POST request");
            var httpContent = CreateContent(content);
            var response = PostEndpoint(SendDocumentEnpoint, httpContent);
            if(response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                _logger.AppendLine($"Request sent successfully. Status Code: {response.StatusCode}");
                var result = response.Content.ReadAsStringAsync().Result;
                _logger.AppendLine(result);
                return result;
            }
            _logger.AppendLine($"Request failed. Status Code: {response.StatusCode}");
            _logger.AppendLine(response.Content.ReadAsStringAsync().Result);
            return null;
        }
        
        private StringContent CreateContent(string content)
        {
            var httpContent = new StringContent(content, Encoding.UTF8, "application/xml");
            httpContent.Headers.Add("X-PEF-DocumentType", _config.DocumentType);
            httpContent.Headers.Add("X-PEF-DocumentFormat", "Ubl");
            return httpContent;
        }
    }
}
