using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public partial class PensionPaymentDetailModel
    {
        [JsonProperty("pay_detail_id")]
        public int PayDetailId { get; set; }

        [JsonProperty("alw_type_id")]
        public int AlwTypeId { get; set; }

        [JsonProperty("base")]
        public double Base { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}
