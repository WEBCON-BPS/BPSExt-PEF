using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCon.BpsExt.PEF.CustomActions.Models
{
    public class ReceivedOrSendDocumentStatusChangedMessage
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
