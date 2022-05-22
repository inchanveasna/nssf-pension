using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class FamilyStatusModel
    {
        [JsonProperty("fs_id")]
        public int FsId { get; set; }

        [JsonProperty("fs_name_en")]
        public string FsNameEn { get; set; }

        [JsonProperty("fs_name_kh")]
        public string FsNameKh { get; set; }
    }
}
