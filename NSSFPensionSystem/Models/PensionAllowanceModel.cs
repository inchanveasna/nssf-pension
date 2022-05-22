using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class PensionAllowanceModel
    {
        [JsonProperty("alw_id")]
        public int AlwId { get; set; }

        [JsonProperty("guid")]
        public string Guid { get; set; }

        [JsonProperty("alw_code")]
        public string AlwCode { get; set; }

        [JsonProperty("alw_date")]
        public DateTime AlwDate { get; set; }

        [JsonProperty("cla_id")]
        public int ClaId { get; set; }

        [JsonProperty("inv_id")]
        public Nullable<int> InvId { get; set; }

        [JsonProperty("num_con_month")]
        public int NumConMonth { get; set; }

        [JsonProperty("total_assume_wage")]
        public decimal TotalAssumeWage { get; set; }

        [JsonProperty("ps_rate")]
        public double PsRate { get; set; }

        [JsonProperty("inflation_rate")]
        public int InflationRate { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("dep_id")]
        public int DepId { get; set; }

        [JsonProperty("div_id")]
        public string DivId { get; set; }

        [JsonProperty("input_by")]
        public int InputBy { get; set; }

        [JsonProperty("input_date")]
        public DateTime InputDate { get; set; }

        [JsonProperty("edit_by")]
        public int EditBy { get; set; }

        [JsonProperty("edit_date")]
        public DateTime EditDate { get; set; }

        [JsonProperty("td_pension_allowance_detail")]
        public List<PensionAllowanceDetailModel> Details { get; set; } = new List<PensionAllowanceDetailModel>();
    }
}
