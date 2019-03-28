using Newtonsoft.Json;

namespace CorePexel.Models
{
   public class PageModel
   {
      [JsonProperty("page")]
      public int PageNumber { get; set; }

      [JsonProperty("per_page")]
      public int PerPage { get; set; }

      [JsonProperty("total_results")]
      public int TotalResults { get; set; }

      [JsonProperty("next_page")]
      public string NextPage { get; set; }
   }
}