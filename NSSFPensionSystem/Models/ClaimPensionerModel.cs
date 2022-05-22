using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace NSSFPensionSystem.Models
{
    public class ClaimPensionerModel: MemberModel
    {
       
        [JsonProperty("contribution")]
        public List<ContributionModel> Contributions { get; set; }
    }
}
