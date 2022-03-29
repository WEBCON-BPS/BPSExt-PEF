using System.Text;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;

namespace WebCon.BpsExt.PEF.CustomActions.GetEventsFromQueue
{
    public class QueueApiHelper : ApiHelperBase.ApiHelperBase
    {
        private const string GetMessageFromQueueEnpoint = "/api/v1/events-queue/messages";
        private const string DeleteMessageFromQueueEnpoint = "/api/v1/events-queue/messages/";

        public QueueApiHelper(GetEventsFromQueueConfig config, ActionWithoutDocumentContext context, StringBuilder logger) : base(config.ConnectionID, context, logger){}

        public string GetMessageFromQueue(out bool noMessages)
        {
            noMessages = false;
            var response = GetHttpResponseFromEndpoint(GetMessageFromQueueEnpoint);
            if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                noMessages = true;
                return null;
            }
            return response.Content.ReadAsStringAsync().Result;
        }

        public void DeleteMessage(string messageId)
        {
            var respose = _client.DeleteAsync($"{DeleteMessageFromQueueEnpoint}{messageId}").Result;
            if (respose.StatusCode == System.Net.HttpStatusCode.NoContent)
                return;

            _logger.AppendLine($"The message could not be deleted from the queue. StatusCode {respose.StatusCode} {respose.Content.ReadAsStringAsync().Result}");
        }         
    } 
}
