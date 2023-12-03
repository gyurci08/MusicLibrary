
using MusicLibrary.Models.Objects;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.ViewModel
{
    public class MusicViewModel
    {

        public Music music { get; set; } = new Music();

        [Required(ErrorMessage = "Please select at least one author.")]
        public int[] SelectedArtists { get; set; }



    }
}
