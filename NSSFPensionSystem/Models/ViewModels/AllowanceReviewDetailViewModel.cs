using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models.ViewModels
{
    public class AllowanceReviewDetailViewModel
    {
        [JsonProperty("cla_id")]
        public int ClaId { get; set; }

        [JsonProperty("int_id")]
        public int IntId { get; set; }

        [JsonProperty("int_name")]
        public string IntName { get; set; }

        [JsonProperty("extra_day")]
        public int ExtraDay { get; set; }

        [JsonProperty("alw_type_id")]
        public int AlwTypeId { get; set; }

        [JsonProperty("alw_type_name")]
        public string AlwTypeName { get; set; }

        [JsonProperty("pension_amount")]
        public double PensionAmount { get; set; }
    }
}
