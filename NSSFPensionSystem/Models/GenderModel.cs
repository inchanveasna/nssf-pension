using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class GenderModel
    {
        [JsonProperty("gen_id")]
        public string GenID { get; set; }

        [JsonProperty("gen_name")]
        public string GenName { get; set; }
    }
}
