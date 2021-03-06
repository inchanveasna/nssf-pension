using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ClaimDocumentModel
    {
        [JsonProperty("cla_id")]
        public int ClaimID { get; set; } = 0;

        [JsonProperty("doc_id")]
        public int DocID { get; set; } = 0;

        //[JsonProperty("doc_name")]
        //public string DocName { get; set; } = "";

        [JsonProperty("doc_code")]
        public string DocCode { get; set; } = "";

        [JsonProperty("doc_date")]
        public DateTime? DocDate { get; set; }


        public string DocDateString
        {
            get { return DocDate == null ? "" : DocDate.Value.ToString("dd-MM-yyyy"); }
        }

        [JsonProperty("doc_by")]
        public string DocBy { get; set; } = "";

        [JsonProperty("doc_at")]
        public string DocAt { get; set; } = "";
    }
}
