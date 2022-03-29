using System.Text;
using WebCon.WorkFlow.SDK.Common.Model;

namespace WebCon.BpsExt.PEF.CustomActions.ConfirmRead
{
    public class ConfirmApiHelper : ApiHelperBase.ApiHelperBase
    {
        private const string ConfirmReadEnpoint = "/api/v1/documents/{0}/read-confirmation";

        public ConfirmApiHelper(ConfirmReadConfig config, BaseContext context, StringBuilder logger) : base(config.ConnectionID, context, logger) { }

        public bool ConfirmRead(string documentId)
        {
            _logger.AppendLine("Sending POST request");
            var response = PostEndpoint(string.Format(ConfirmReadEnpoint, documentId), null);
            if(response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                _logger.AppendLine($"Request sent successfully. Status Code: {response.StatusCode}");
                _logger.AppendLine(response.Content.ReadAsStringAsync().Result);
                return true;
            }
            _logger.AppendLine($"Request failed. Status Code: {response.StatusCode}");
            _logger.AppendLine(response.Content.ReadAsStringAsync().Result);
            return false;
        }    
    }
}
