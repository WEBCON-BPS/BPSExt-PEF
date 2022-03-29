using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCon.BpsExt.PEF.CustomActions.Models
{
    public class StartNewDocumentMessage
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }
}
