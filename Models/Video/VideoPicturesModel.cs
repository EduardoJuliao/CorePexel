using Newtonsoft.Json;

namespace CorePexel.Models.Video
{
   public class VideoPicturesModel
   {
      public long Id { get; set; }

      [JsonProperty("picture")]
      public string PictureUrl { get; set; }
      
      [JsonProperty("nr")]
      public int Order { get; set; }
   }
}