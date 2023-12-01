using static System.Reflection.Metadata.BlobBuilder;

namespace MusicLibrary.Models.Objects
{
    public class Music
    {
        public Music() => Artists = new HashSet<Artist>();


        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }



        public ICollection<Artist> Artists { get; set; }





    }
}
