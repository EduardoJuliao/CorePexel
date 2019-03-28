using System.Collections.Generic;

namespace CorePexel.Models.Video
{
    public class VideoPageModel : PageModel
    {
        public IEnumerable<VideoModel> Videos {get;set;}
    }
}