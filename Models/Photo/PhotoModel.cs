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
      /// Photographer pexel url page
      /// </summary>
      public string Photographer { get; set; }

      /// <summary>
      /// All photos Urls
      /// </summary>
      /// <value></value>
      [JsonProperty("src")]
      public PhotoSourceModel Sources { get; set; }
   }
}