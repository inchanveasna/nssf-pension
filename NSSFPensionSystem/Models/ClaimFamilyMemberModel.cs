using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class ClaimFamilyMemberModel
    {
        [JsonProperty("mem_id")]
        public int MemId { get; set; } = 0;

        [JsonProperty("cla_id")]
        public int ClaId { get; set; } = 0;

        [JsonProperty("first_name_kh")]
        public string FirstNameKh { get; set; } = "";

        [JsonProperty("last_name_kh")]
        public string LastNameKh { get; set; } = "";

        [JsonProperty("first_name_en")]
        public string FirstNameLatin { get; set; } = "";

        [JsonProperty("last_name_en")]
        public string LastNameLatin { get; set; } = "";

        [JsonProperty("gen_id")]
        public string GenId { get; set; } = "0";

        [JsonProperty("dob")]
        public DateTime? Dob { get; set; }


        public string DobString
        {
            get { return Dob == null ? "" : Dob.Value.ToString("dd-MM-yyyy"); }
        }

        [JsonProperty("national_id")]
        public int NationalId { get; set; } = 33;

        [JsonProperty("rel_id")]
        public int RelId { get; set; }

        [JsonProperty("isRepresenter")]
        public bool IsRepresenter { get; set; }

        [JsonProperty("isCareTaker")]
        public bool IsCareTaker { get; set; }

        [JsonProperty("id_type")]
        public int IdType { get; set; } = 0;

        [JsonProperty("id_number")]
        public string IdNumber { get; set; } = "";

        [JsonProperty("phone")]
        public string Phone { get; set; } = "";

        [JsonProperty("email")]
        public string Email { get; set; } = "";

        [JsonProperty("fs_id")]
        public int FsId { get; set; } = 1;

        [JsonProperty("health_id")]
        public int HealthId { get; set; } = 1;

        [JsonProperty("bank_id")]
        public int BankId { get; set; } = 1;

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; } = "";

        [JsonProperty("home")]
        public string Home { get; set; } = "";

        [JsonProperty("street")]
        public string Street { get; set; } = "";

        [JsonProperty("village")]
        public string Village { get; set; } = "";

        [JsonProperty("com_id")]
        public int ComId { get; set; } = -1;

        [JsonProperty("mem_docs")]
        public List<ClaimFamilyMemberDocumentModel> Documents { get; set; } = new List<ClaimFamilyMemberDocumentModel>();

        [JsonProperty("nationality")]
        public string Nationality { get; set; } = "";

        [JsonProperty("relationship")]
        public string Relationship { get; set; } = "";
    }
}
