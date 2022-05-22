using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class PensionPaymentModel
    {
        [JsonProperty("pay_id")]
        public int PayId { get; set; } = 0;

        [JsonProperty("guid")]
        public string Guid { get; set; } = "";

        [JsonProperty("pay_code")]
        public string PayCode { get; set; } = "";

        [JsonProperty("pay_date")]
        public DateTime PayDate { get; set; }

        [JsonProperty("for_bimonthly")]
        public int ForBimonthly { get; set; } = 1;

        [JsonProperty("for_month")]
        public int ForMonth { get; set; }

        [JsonProperty("for_year")]
        public int ForYear { get; set; }

        [JsonProperty("int_id")]
        public int IntId { get; set; }

        [JsonProperty("sta_id")]
        public int StaId { get; set; }

        [JsonProperty("dep_id")]
        public int DepId { get; set; }

        [JsonProperty("div_id")]
        public string DivId { get; set; }

        [JsonProperty("input_by")]
        public int InputBy { get; set; }

        [JsonProperty("input_datetime")]
        public DateTime InputDatetime { get; set; }

        [JsonProperty("edit_by")]
        public int EditBy { get; set; }

        [JsonProperty("edit_datetime")]
        public DateTime EditDatetime { get; set; }

        [JsonProperty("Pensioners")]
        public List<PensionPaymentPensionerModel> Pensioners { get; set; }
    }
}
