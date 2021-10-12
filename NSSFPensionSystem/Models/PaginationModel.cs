using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NSSFPensionSystem.Models
{
    public class PaginationModel
    {
        [JsonProperty("current_page")]
        public int? Page { get; set; } = 1;

        [JsonProperty("row_per_page")]
        public int? Size { get; set; } = 10;

        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("total_pages")]
        public int? TotalPages => Total.HasValue ? (int)Math.Ceiling(Total.Value / (double)Size) : (int?)null;
    }
}
