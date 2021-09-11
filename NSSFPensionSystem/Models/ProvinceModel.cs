using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ProvinceModel
    {
        [JsonProperty("pro_id")]
        public int ProID { get; set; }

        [JsonProperty("pro_name_latin")]
        public string ProNameLatin { get; set; }

        [JsonProperty("pro_name_khmer")]
        public string ProNameKhmer { get; set; }

        [JsonProperty("pro_type")]
        public string ProType { get; set; }

        [JsonProperty("pro_area")]
        public string ProArea { get; set; }

        [JsonProperty("pro_abbreviation")]
        public string ProAbbreviation { get; set; }

        [JsonProperty("pro_id_old")]
        public int ProIDOld { get; set; }
    }
}
