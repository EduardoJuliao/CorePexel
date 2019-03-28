using System.Collections.Generic;

namespace CorePexel.Models.Video
{
    public class VideoPageModel : PageModel
    {
        /// <summary>
        /// All videos in Page
        /// </summary>
        /// <value></value>
        public IEnumerable<VideoModel> Videos {get;set;}
    }
}