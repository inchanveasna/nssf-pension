using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ContributionModel : EnterpriseModel
    {
        [JsonProperty("con_id")]
        public string ConId { get; set; }

        [JsonProperty("con_fordate")]
        public DateTime ConFordate { get; set; }

        [JsonProperty("ben_wage")]
        public Decimal BenWage { get; set; }

        [JsonProperty("assum_wage")]
        public Decimal AssumeWage { get; set; }

        [JsonProperty("con_pay_ps")]
        public Decimal ConPay { get; set; }
    }
}
