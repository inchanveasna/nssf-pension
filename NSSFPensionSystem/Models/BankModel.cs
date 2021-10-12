using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class BankModel
    {
        [JsonProperty("bank_id")]
        public int BankId { get; set; }

        [JsonProperty("bank_name_kh")]
        public string BankNameKh { get; set; }

        [JsonProperty("bank_name_en")]
        public string BankNamEn { get; set; }
    }
}
