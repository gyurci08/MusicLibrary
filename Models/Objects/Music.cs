using System.ComponentModel.DataAnnotations;
using static System.Reflection.Metadata.BlobBuilder;

namespace MusicLibrary.Models.Objects
{
    public class Music
    {
        public Music() => Artists = new HashSet<Artist>();


        public int Id { get; set; }
        [Required(ErrorMessage = "A zene címe nincs megadva!")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage = "A zene éve nincs megadva!")]
        [Range(1800,2500, ErrorMessage = "Az év 1800 és 2500 közötti érték lehet!")]
        public int Year { get; set; }



        public ICollection<Artist> Artists { get; set; }





    }
}
