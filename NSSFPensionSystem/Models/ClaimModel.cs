using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ClaimModel
    {
        [JsonProperty("cla_id")]
        public int ClaId { get; set; }

        [JsonProperty("ps_type_id")]
        public int PsTypeId { get; set; } = 1;

        [JsonProperty("cla_code")]
        public string ClaCode { get; set; }

        [JsonProperty("cla_date")]
        public Nullable<DateTime> ClaDate { get; set; }

        [JsonProperty("guid")]
        public string GUID { get; set; }

        [JsonProperty("ben_id")]
        public string BenId { get; set; }

        [JsonProperty("ent_id")]
        public Nullable<int> EntId { get; set; } = 0;

        [JsonProperty("national_id")]
        public int NationalId { get; set; } = 33;

        [JsonProperty("id_type")]
        public int IdType { get; set; }

        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        [JsonProperty("phone1")]
        public string Phone1 { get; set; }

        [JsonProperty("phone2")]
        public string Phone2 { get; set; }

        [JsonProperty("fs_id")]
        public int FsId { get; set; } = 1;

        [JsonProperty("mar_date")]
        public DateTime MarDate { get; set; }

        [JsonProperty("mar_cert_date")]
        public DateTime MarCertDate { get; set; }

        [JsonProperty("mar_cert_code")]
        public string MarCertCode { get; set; }

        [JsonProperty("mar_cert_by")]
        public string MarCertBy { get; set; }

        [JsonProperty("mar_cert_issued_at")]
        public string MarCertIssuedAt { get; set; }

        [JsonProperty("home")]
        public string Home { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("village")]
        public string Village { get; set; }

        [JsonProperty("com_id")]
        public int ComId { get; set; }

        [JsonProperty("status_id")]
        public int StatusId { get; set; } = 1;

        [JsonProperty("div_id")]
        public string DivId { get; set; } = "008";

        [JsonProperty("input_by")]
        public int InputBy { get; set; } = 2044;

        [JsonProperty("input_date")]
        public DateTime InputDate { get; set; } = DateTime.Now;

        [JsonProperty("edit_by")]
        public Nullable<int> EditBy { get; set; } = 0;

        [JsonProperty("edit_date")]
        public Nullable<DateTime> EditDate { get; set; }
        [JsonProperty("note")]
        public string note { get; set; }

        public bool is_representer { get; set; }

        [JsonProperty("fam")]
        public List<ClaimFamilyMemberModel> Members { get; set; } = new List<ClaimFamilyMemberModel>();

        [JsonProperty("claimDoc")]
        public List<ClaimDocumentModel> Documents { get; set; } = new List<ClaimDocumentModel>();

        [JsonProperty("pensioner")]
        public ClaimPensionerModel Pensioner { get; set; } = new ClaimPensionerModel();


        [JsonProperty("pro_id")]
        public int ProId { get; set; }

        [JsonProperty("dis_id")]
        public int DisId { get; set; }

        [JsonProperty("bank_id")]
        public int BankId { get; set; } = 1;

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }
    }
}
