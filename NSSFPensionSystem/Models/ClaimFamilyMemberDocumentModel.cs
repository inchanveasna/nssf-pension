using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ClaimFamilyMemberDocumentModel
    {
        [JsonProperty("mem_id")]
        public int MemId { get; set; } = 0;

        [JsonProperty("doc_id")]
        public int DocID { get; set; } = 1;

        [JsonProperty("doc_name")]
        public string DocName { get; set; } = "";

        [JsonProperty("doc_code")]
        public string DocCode { get; set; } = "";

        [JsonProperty("doc_date")]
        public Nullable<DateTime> DocDate { get; set; } = null;

        [JsonProperty("dob_date_string")]
        public string DocDateString
        {
            get { return DocDate == null ? "" : DocDate.Value.ToString("dd-MM-yyyy"); }
            set
            {
                if (DocDateString == null || DocDateString == "") DocDate = null;
                string[] val = value.Split('-');
                if (val.Length == 3) DocDate = new DateTime(Convert.ToInt32(val[2]), Convert.ToInt32(val[1]), Convert.ToInt32(val[0]));
                else DocDate = null;
            }
        }

        [JsonProperty("doc_by")]
        public string DocBy { get; set; } = "";

        [JsonProperty("doc_at")]
        public string DocAt { get; set; } = "";

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
