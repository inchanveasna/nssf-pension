using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Models
{
    public class UserModel
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public string AccessToken { get; set; }
    }
}
