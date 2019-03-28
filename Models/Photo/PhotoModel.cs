using Newtonsoft.Json;

namespace CorePexel.Models
{
   public class PhotoModel
   {
      public int Id { get; set; }

      public int Width { get; set; }

      public int Height { get; set; }

      /// <summary>
      /// Photo Url
      /// </summary>
      public string Url { get; set; }

      /// <summary>
      /// Photographer Name
      /// </summary>
      public string Photographer { get; set; }

      /// <summary>
      /// Photographer url pexels page
      /// </summary>
      /// <value></value>
      [JsonProperty("photographer_url")]
      public string PhotographerUrl { get; set; }

      /// <summary>
      /// All photos Urls
      /// </summary>
      /// <value></value>
      [JsonProperty("src")]
      public PhotoSourceModel Sources { get; set; }
   }
}