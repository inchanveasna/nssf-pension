using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models.ViewModels
{
    public class AllowanceViewModel : AllowanceReviewViewModel
    {
        [JsonProperty("alw_id")]
        public int AlwId { get; set; }

        [JsonProperty("alw_date")]
        public DateTime AlwDate { get; set; }
    }
}
