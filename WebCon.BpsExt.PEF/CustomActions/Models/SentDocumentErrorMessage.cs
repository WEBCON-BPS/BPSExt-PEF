using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCon.BpsExt.PEF.CustomActions.Models
{
    public class SentDocumentErrorMessage
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("errors")]
        public List<Error> Errors { get; set; }
    }

    public class Error
    {
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

}
