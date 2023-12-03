using MusicLibrary.Models.Objects;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.ViewModel
{
    public class ArtistViewModel
    {
        [Required]
        public Artist artist { get; set; }

    }
}
