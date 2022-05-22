using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace NSSFPensionSystem.Models
{
    public class MemberModel : EnterpriseModel
    {
        [JsonProperty("ben_id")]
        public string BenId { get; set; }

        [JsonProperty("ben_note")]
        public string BenNote { get; set; }

        [JsonProperty("ben_char")]
        public string BenChar { get; set; }

        [JsonProperty("id_type")]
        public int IdType { get; set; }

        [JsonProperty("id_card")]
        public string IdCard { get; set; }

        [JsonProperty("fname_eng")]
        public string FnameEng { get; set; }

        [JsonProperty("lname_eng")]
        public string LnameEng { get; set; }

        [JsonProperty("fname_kh")]
        public string FnameKh { get; set; }

        [JsonProperty("lname_kh")]
        public string LnameKh { get; set; }

        [Display(Name = "ភេទ")]
        [JsonProperty("sex_id")]
        public string SexId { get; set; }

        [JsonProperty("dob")]
        public Nullable<DateTime> Dob { get; set; }

        [JsonProperty("fs_id")]
        public int FamilyStatusId { get; set; }

        [JsonProperty("nat_id")]
        public int NationalityId { get; set; }

        [JsonProperty("pro_id")]
        public int ProId { get; set; }

        [JsonProperty("dis_id")]
        public int DisId { get; set; }

        [JsonProperty("com_id")]
        public int ComId { get; set; }

        [JsonProperty("village")]
        public string Village { get; set; }

        [JsonProperty("home")]
        public string Home { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [Display(Name = "គោត្តនាម-នាម")]
        [DataType(DataType.Text)]
        [JsonProperty("fullname_kh")]
        public string FullnameKh { get { return FnameKh + " " + LnameKh; } set { } }

        [Display(Name = "គោត្តនាម-នាម (ឡាតាំង)")]
        [DataType(DataType.Text)]
        [JsonProperty("fullname_en")]
        public string FullnameEn { get { return FnameEng + " " + LnameEng; } set { } }
    }
}
