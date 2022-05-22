using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NSSFPensionSystem.Models
{
    public class BreadcrumbModel
    {
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        
    }
}
