using Newtonsoft.Json;

namespace CorePexel.Models.Video
{
   public class VideoFilesModel
   {
      public long Id { get; set; }
      
      public string Quality { get; set; }

      [JsonProperty("file_type")]
      
      public string FileType { get; set; }
      
      public int Width { get; set; }
      
      public int Height { get; set; }
      
      [JsonProperty("link")]
      public string VideoLink { get; set; }
   }
}