using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class PensionTypeModel
    {
        [JsonProperty("ps_type_id")]
        public int TypeId { get; set; }

        [JsonProperty("ps_type_name_en")]
        public string TypeNameEn { get; set; }

        [JsonProperty("ps_type_name_kh")]
        public string TypeNameKh { get; set; }
    }
}
