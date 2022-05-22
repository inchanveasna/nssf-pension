using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class EmployeeModel
    {
        [JsonProperty("emp_id")]
        public int EmpId { get; set; }

        [JsonProperty("emp_name_first_khmer")]
        public string EmpNameFirstKhmer { get; set; }

        [JsonProperty("emp_name_last_khmer")]
        public string EmpNameLastKhmer { get; set; }

        [JsonProperty("emp_name_first_latin")]
        public string EmpNameFirstLatin { get; set; }

        [JsonProperty("emp_name_last_latin")]
        public string EmpNameLastLatin { get; set; }

        [JsonProperty("dep_id")]
        public int DepId { get; set; }

        [JsonProperty("div_id")]
        public string DivId { get; set; }

        [JsonProperty("menus")]
        public List<MenuModel> Menus { get; set; } = new List<MenuModel>();
    }
}
