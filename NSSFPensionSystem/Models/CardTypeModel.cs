using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class CardTypeModel
    {
        [JsonProperty("car_id")]
        public int CarId { get; set; }

        [JsonProperty("car_name_khmer")]
        public string CarNameKhmer { get; set; }

        [JsonProperty("car_name_latin")]
        public string CarNameLatin { get; set; }

        [JsonProperty("car_active")]
        public bool CarActive { get; set; }
    }
}
