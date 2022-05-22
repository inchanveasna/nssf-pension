using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class PensionPaymentPensionerModel
    {
        [JsonProperty("pay_detail_id")]
        public int PayDetailId { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("pay_id")]
        public int PayId { get; set; }

        [JsonProperty("alw_id")]
        public int AlwId { get; set; }

        [JsonProperty("cla_id")]
        public int ClaId { get; set; }

        [JsonProperty("bank_id")]
        public int BankId { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("total_amount")]
        public double TotalAmount { get; set; }

        [JsonProperty("Details")]
        public List<PensionPaymentDetailModel> Details { get; set; }
    }
}
