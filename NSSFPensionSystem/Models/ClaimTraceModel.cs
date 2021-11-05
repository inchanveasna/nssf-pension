using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ClaimTraceModel
    {
         [JsonProperty("cla_id")]
        public int ClaimId { get; set; }

        [JsonProperty("sta_id")]
        public byte StatusId { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("div_id")]
        public string DivId { get; set; } = "270";

        [JsonProperty("input_by")]
        public int InputBy { get; set; } = 2044;

        [JsonProperty("input_date")]
        public DateTime InputDatetime { get; set; }



        [JsonProperty("emp_name")]
        public string EmployeeName { get; set; }


        [JsonProperty("desc")]
        public string StatusDesc { get; set; }
    }
}
