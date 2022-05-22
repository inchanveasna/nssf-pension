using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models.ViewModels
{
    public class AllowanceReviewViewModel : MemberModel
    {
        
        [JsonProperty("cla_id")]
        public int ClaId { get; set; }

        [JsonProperty("cla_code")]
        public string ClaCode { get; set; }
        
        [JsonProperty("guid")]
        public string GUID { get; set; }

        [JsonProperty("ps_type_id")]
        public string PsTypeID { get; set; }

        [JsonProperty("ps_type_name_kh")]
        public string PsTypeNameKh { get; set; }

        [JsonProperty("num_con_year")]
        public int NumConYear { get; set; }

        [JsonProperty("num_con_month")]
        public int NumConMonth { get; set; }

        [JsonProperty("ps_rate")]
        public double PsRate { get; set; }

        [JsonProperty("total_assume_wage")]
        public decimal TotalAssumeWage { get; set; }

        [JsonProperty("avg_assume_wage")]
        public decimal AvgAssumeWage { get; set; }

        [JsonProperty("effective_date")]
        public DateTime EffectiveDate { get; set; }

        

        [JsonProperty("detail")]
        public List<AllowanceReviewDetailViewModel> Details { get; set; } = new List<AllowanceReviewDetailViewModel>();
    }
}
