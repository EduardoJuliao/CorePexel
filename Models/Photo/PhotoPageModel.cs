using System.Collections.Generic;
using Newtonsoft.Json;

namespace CorePexel.Models
{
    public class PhotoPageModel : PageModel
    {
        /// <summary>
        /// All photos in the page
        /// </summary>
        public IEnumerable<PhotoModel> Photos { get; set; }
    }
}