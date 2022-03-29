using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCon.WorkFlow.SDK.Common.Model;

namespace WebCon.BpsExt.PEF.CustomActions.DownloadDocument
{
    public class DownloadApiHelper : ApiHelperBase.ApiHelperBase
    {
        private const string DownloadDocumentEnpoint = "/api/v1/documents/{0}/content";

        public DownloadApiHelper(DownloadDocumentConfig config, BaseContext context, StringBuilder logger) : base(config.ConnectionID, context, logger) { }

        public string DownloadDocument(string documentId, string documentType)
        {
            _logger.Append($"Downloading document of id: {documentId}");
            _client.DefaultRequestHeaders.Add("X-PEF-DocumentType", documentType);
            var response = GetStringValueFromEndpoint(String.Format(DownloadDocumentEnpoint, documentId));
            return response;
        }    
    }
}
