using System.Collections.Generic;
using Newtonsoft.Json;

namespace CorePexel.Models
{
    public class PhotoPageModel : PageModel
    {
        public IEnumerable<PhotoModel> Photos { get; set; }
    }
}