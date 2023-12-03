using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace MusicLibrary.Models.Objects
{
    public class Music
    {
        public Music() => Artists = new HashSet<Artist>();


        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Range(1800,2500)]
        public int Year { get; set; }



        public ICollection<Artist> Artists { get; set; }





    }
}
