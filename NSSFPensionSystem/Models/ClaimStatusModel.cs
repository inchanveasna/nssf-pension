using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace NSSFPensionSystem.Models
{
    public class ClaimStatusModel
    {
        [JsonProperty("sta_id")]
        public byte StaId { get; set; }

        [JsonProperty("sta_name")]
        public string StaName { get; set; }

        [JsonProperty("desc")]
        public string StaDescription { get; set; }
    }
}
