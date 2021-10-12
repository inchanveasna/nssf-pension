using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ResponseModel : PaginationModel
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; } = "";

        [JsonProperty("data")]
        public object Data { get; set; }

        
    }
}
