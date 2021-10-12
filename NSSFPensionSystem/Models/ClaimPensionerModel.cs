using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ClaimPensionerModel
    {
        [JsonProperty("ben_id")]
        public string BenId { get; set; }

        [JsonProperty("ben_note")]
        public string BenNote { get; set; }

        [JsonProperty("ben_char")]
        public string BenChar { get; set; }

        [JsonProperty("ben_idcard")]
        public string BenIdcard { get; set; }

        [JsonProperty("ben_fname_eng")]
        public string BenFnameEng { get; set; }

        [JsonProperty("ben_lname_eng")]
        public string BenLnameEng { get; set; }

        [JsonProperty("ben_fname_kh")]
        public string BenFnameKh { get; set; }

        [JsonProperty("ben_lname_kh")]
        public string BenLnameKh { get; set; }

        [JsonProperty("ben_sex_id")]
        public string BenSexId { get; set; }

        [JsonProperty("ben_dob")]
        public Nullable<DateTime> BenDob { get; set; }

        [JsonProperty("ben_nationality_id")]
        public int BenNationalityId { get; set; }

        [JsonProperty("nat_name_kh")]
        public string NatNameKh { get; set; }

        [JsonProperty("ent_id")]
        public Nullable<int> EntId { get; set; }

        [JsonProperty("ent_name_khmer")]
        public string EntNameKhmer { get; set; }

        [JsonProperty("ent_name_latin")]
        public string EntNameLatin { get; set; }

        [JsonProperty("num_contribution")]
        public int NumContribution { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }






        [JsonProperty("fullname_kh")]
        public string FullnameKh { get { return BenFnameKh + " " + BenLnameKh; } set { } }

        [JsonProperty("fullname_en")]
        public string FullnameEn { get { return BenFnameEng + " " + BenLnameEng; } set { } }
    }
}
