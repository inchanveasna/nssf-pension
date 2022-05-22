using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class PensionAllowanceDetailModel
    {
        [JsonProperty("alw_id")]
        public int AlwId { get; set; }

        [JsonProperty("alw_type_id")]
        public int AlwTypeId { get; set; }

        [JsonProperty("extra_day")]
        public int ExtraDay { get; set; }

        [JsonProperty("pension_amount")]
        public double PensionAmount { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("last_payment_date")]
        public Nullable<DateTime> LastPaymentDate { get; set; }
    }
}
