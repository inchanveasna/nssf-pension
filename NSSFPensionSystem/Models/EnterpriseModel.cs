using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class EnterpriseModel
    {
        [JsonProperty("ent_id")]
        public int EntId { get; set; }

        [JsonProperty("ent_area")]
        public string EntArea { get; set; }

        [JsonProperty("ent_name_khmer")]
        public string EntNameKhmer { get; set; }

        [JsonProperty("ent_name_latin")]
        public string EntNameLatin { get; set; }
    }
}
