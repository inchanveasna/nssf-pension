using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class CommuneModel
    {
        [JsonProperty("com_id")]
        public int ComId { get; set; }

        [JsonProperty("com_name_khmer")]
        public string ComNameKhmer { get; set; }

        [JsonProperty("com_name_latin")]
        public string ComNameLatin { get; set; }

        [JsonProperty("com_type")]
        public string ComType { get; set; }

        [JsonProperty("dis_id")]
        public int DisID { get; set; }
    }
}
