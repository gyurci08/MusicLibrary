using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.Objects
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        [MinLength(2)]
        public string Name { get; set; } = null!;


        public IList<ArtistMusic> ArtistMusics { get; set; }
    }
}


