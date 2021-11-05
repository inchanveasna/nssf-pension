using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class RelationshipModel
    {
        [JsonProperty("rel_id")]
        public int RelId { get; set; }

        [JsonProperty("rel_desc")]
        public string RelDesc { get; set; }

        [JsonProperty("sex_id")]
        public string SexId { get; set; }

        [JsonProperty("is_family_member")]
        public Nullable<bool> IsFamilyMember { get; set; }
    }
}
