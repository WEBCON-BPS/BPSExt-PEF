using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCon.BpsExt.PEF.CustomActions.Models
{
    public class DocumentReceivedMessage : StartNewDocumentMessage
    {
        [JsonProperty("businessValidationReport")]
        public BusinessValidationReport BusinessValidationReport { get; set; }
    }

    public class BusinessValidationReport
    {
        [JsonProperty("reportDate")]
        public DateTime ReportDate { get; set; }

        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }

    }
}
