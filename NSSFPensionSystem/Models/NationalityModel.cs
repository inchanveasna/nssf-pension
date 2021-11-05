using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class NationalityModel
    {
        [JsonProperty("nat_id")]
        public int NatID{ get; set; }

        [JsonProperty("nat_name_eng")]
        public string NatNameEng { get; set; }

        [JsonProperty("nat_name_kh")]
        public string NatNameKh { get; set; }

        [JsonProperty("nat_order")]
        public int NatOrder { get; set; }

        [JsonProperty("nat_isuse")]
        public bool NatIsuse { get; set; }
    }
}
