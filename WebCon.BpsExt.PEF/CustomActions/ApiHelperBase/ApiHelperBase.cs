using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using WebCon.WorkFlow.SDK.Common.Model;
using WebCon.WorkFlow.SDK.Tools.Data.Model;

namespace WebCon.BpsExt.PEF.CustomActions.ApiHelperBase
{
    public class ApiHelperBase
    {
        private const string authEnpoint = "/oauth2/token";
        internal HttpClient _client;
        private int _connectionId;
        private BaseContext _context;
        internal StringBuilder _logger;

        public ApiHelperBase(int connectionId, BaseContext context, StringBuilder logger)
        {
            _logger = logger;
            _connectionId = connectionId;
            _context = context;
            _client = CreateClient();
            
        }

        internal string GetStringValueFromEndpoint(string endpoint)
        {
            var result = _client.GetAsync(endpoint).Result;
            if (result.IsSuccessStatusCode)
            {
                LogResponseWithMessage("Request done", result);
                return result.Content.ReadAsStringAsync().Result;
            }
            LogResponseWithMessage("Request failed", result);
            return null;
        }

        internal HttpResponseMessage GetHttpResponseFromEndpoint(string endpoint)
        {
            var result = _client.GetAsync(endpoint).Result;
            if (result.StatusCode == System.Net.HttpStatusCode.OK || result.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                LogResponseWithMessage("Request done", result);
                return result;
            }
            LogResponseWithMessage("Request failed", result);
            return null;
        }
        private void LogResponseWithMessage(string message, HttpResponseMessage response)
        {
            _logger.AppendLine($"{message}. Status Code: {response.StatusCode}");
            _logger.AppendLine(response?.Content?.ReadAsStringAsync()?.Result);
        }

        internal HttpResponseMessage PostEndpoint(string endpoint, HttpContent content)
        {
            var result = _client.PostAsync(endpoint, content).Result;
            return result;
        }

        private HttpClient CreateClient()
        {
            _logger.AppendLine("Creating http client");
            var connection = WebCon.WorkFlow.SDK.Tools.Data.ConnectionsHelper.GetConnectionToWebService(new GetByConnectionParams(_connectionId, _context));
            var client = new HttpClient();
            client.BaseAddress = new Uri(connection.Url);
            AuthClient(client, connection);
            return client;
        }

        private void AuthClient(HttpClient client, WebServiceConnection connection)
        {
            _logger.AppendLine("Downloading acces token");
            var request = CreateAuthRequest(connection);
            var result = client.SendAsync(request).Result;
            if (result.IsSuccessStatusCode)
            {
                var responseString = result.Content.ReadAsStringAsync().Result;
                var token = JObject.Parse(responseString)["access_token"].ToString();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                _logger.AppendLine("Token has been added successfully");
                return;
            }
            _logger.AppendLine("Token could not be retrieved");
            _logger.AppendLine(result.StatusCode.ToString());
            result.EnsureSuccessStatusCode();
        }

        private HttpRequestMessage CreateAuthRequest(WebServiceConnection connection)
        {
            var dict = new Dictionary<string, string>();
            dict.Add("client_id", connection.ClientID);
            dict.Add("client_secret", connection.ClientSecret);
            dict.Add("grant_type", "client_credentials");
            return new HttpRequestMessage(HttpMethod.Post, authEnpoint) { Content = new FormUrlEncodedContent(dict) };
        }
    }
}
