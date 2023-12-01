using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.Objects
{
    public class Music
    {
        [Key]
        public int MusicId { get; set; }
        [MinLength(2)]
        public string Title { get; set; } = null!;
        [Range(1930, 2300)]
        public int Year { get; set; }

        public IList<ArtistMusic> ArtistMusics { get; set; }


    }
}
