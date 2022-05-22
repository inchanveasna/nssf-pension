using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models.ViewModels
{
    public class PaymentReviewDetailViewModel
    {
        [JsonProperty("alw_id")]
        public int AlwId { get; set; }

        [JsonProperty("alw_type_id")]
        public int AlwTypeId { get; set; }

        [JsonProperty("int_id")]
        public int IntId { get; set; }

        [JsonProperty("extra_day")]
        public int ExtraDay { get; set; }

        [JsonProperty("alw_type_name")]
        public string AlwTypeName { get; set; }

        [JsonProperty("base")]
        public double Base { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("pension_amount")]
        public double PensionAmount { get; set; }

        [JsonProperty("bank_id")]
        public int BankId { get; set; }

        [JsonProperty("bank_name_kh")]
        public string BankNameKh { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("will_closed")]
        public bool WillClosed { get; set; }
    }
}
