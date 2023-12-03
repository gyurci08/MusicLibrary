
using MusicLibrary.Models.Objects;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.ViewModel
{
    public class MusicViewModel
    {
        [Required]
        public Music music { get; set; }

        [Required]
        public int[] SelectedArtists { get; set; }




    }
}
