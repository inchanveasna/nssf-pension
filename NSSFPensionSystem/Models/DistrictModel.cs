using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class DistrictModel
    {
        [JsonProperty("dis_id")]
        public int DisID { get; set; }

        [JsonProperty("dis_name_khmer")]
        public string DisNameKhmer { get; set; }

        [JsonProperty("dis_name_latin")]
        public string DisNameLatin { get; set; }

        [JsonProperty("dis_type")]
        public string DisType { get; set; }

        [JsonProperty("pro_id")]
        public int ProID { get; set; }
    }
}
