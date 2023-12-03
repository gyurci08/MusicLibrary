
using MusicLibrary.Models.Objects;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.ViewModel
{
    public class MusicViewModel
    {
        [Required]
        public Music music { get; set; }

        [Required(ErrorMessage = "Add meg az előadó nevét!")]
        public int[] SelectedArtists { get; set; }



    }
}
