using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace NSSFPensionSystem.Models
{
    public class CommuneModel
    {
        [Display(Name = "ID")]
        [DataType(DataType.Text)]
        [JsonProperty("com_id")]
        public int ComId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage ="សូមបញ្ជុល")]
        [Display(Name = "Com Name", Prompt = "Input Comm Name")]
        [JsonProperty("com_name_khmer")]
        public string ComNameKhmer { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Com Name Latin")]
        [JsonProperty("com_name_latin")]
        public string ComNameLatin { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Com Type")]
        [JsonProperty("com_type")]
        public string ComType { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "dis ID")]
        [JsonProperty("dis_id")]
        public int DisID { get; set; }
    }
}
