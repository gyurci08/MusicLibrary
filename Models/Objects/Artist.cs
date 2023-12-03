using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.Objects
{
    public class Artist
    {
        public Artist() => Musics = new HashSet<Music>();


        public int Id { get; set; }

        [Required(ErrorMessage = "Az előadó neve nincs megadva!")]
        public string Name { get; set; } = string.Empty;




        public ICollection<Music> Musics { get; set; }
    }
}
