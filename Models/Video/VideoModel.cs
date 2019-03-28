using System.Collections.Generic;
using Newtonsoft.Json;

namespace CorePexel.Models.Video
{
   public class VideoModel
   {
      public int Id { get; set; }
      public int Width { get; set; }
      public int Height { get; set; }
      public string Url { get; set; }
      public string Image { get; set; }
      public int Duration { get; set; }
      
      [JsonProperty("video_files")]
      public IEnumerable<VideoFilesModel> VideoSources { get; set; }
      [JsonProperty("video_pictures")]
      public IEnumerable<VideoPicturesModel> PictureSources { get; set; }
   }
}