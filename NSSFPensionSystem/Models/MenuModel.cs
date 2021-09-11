using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Models
{
    public class MenuModel
    {
        public int menu_id { get; set; }
        public string menu_name { get; set; }
        public string menu_link { get; set; }
        public string menu_icon { get; set; }
        public List<MenuModel> subMenu { get; set; }
    }
}
