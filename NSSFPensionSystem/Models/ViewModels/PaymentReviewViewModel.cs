using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models.ViewModels
{
    public class PaymentReviewViewModel : MemberModel
    {
        [JsonProperty("cla_id")]
        public int ClaId { get; set; }

        [JsonProperty("cla_guid")]
        public string ClaGUID { get; set; }

        [JsonProperty("alw_id")]
        public int AlwId { get; set; }

        [JsonProperty("alw_guid")]
        public string AlwGUID { get; set; }

        [JsonProperty("alw_code")]
        public string AlwCode { get; set; }

        [JsonProperty("cla_code")]
        public string ClaCode { get; set; }

        [JsonProperty("cla_date")]
        public DateTime ClaDate { get; set; }

        [JsonProperty("effective_date")]
        public DateTime EffectiveDate { get; set; }

        [JsonProperty("ps_type_name_kh")]
        public string PsTypeNameKh { get; set; }

        [JsonProperty("new_case")]
        public bool NewCase { get; set; }

        [JsonProperty("bank_id")]
        public int BankId { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("detail")]
        public List<PaymentReviewDetailViewModel> Details { get; set; } = new List<PaymentReviewDetailViewModel>();
    }
}
