using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class DocumentModel
    {
        [JsonProperty("doc_id")]
        public int DocID { get; set; } = 1;

        [JsonProperty("doc_name")]
        public string DocName { get; set; }
    }
}
