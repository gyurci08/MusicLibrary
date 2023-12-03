
using MusicLibrary.Models.Objects;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.ViewModel
{
    public class MusicViewModel
    {
        [Required]
        public Music music { get; set; } = null!;

        [Required(ErrorMessage = "Add meg az előadó(k) nevét!")]
        public int[] SelectedArtists { get; set; } = Array.Empty<int>();



    }
}
