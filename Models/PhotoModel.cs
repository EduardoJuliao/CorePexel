namespace CorePexel.Models
{
    public class PhotoModel
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
        public string Photographer { get; set; }
        public SourceModel Src { get; set; }
    }
}