
using MusicLibrary.Models.Objects;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models.ViewModel
{
    public class MusicViewModel
    {
        [Required(ErrorMessage = "A zene nincs megadva!")]
        public Music music { get; set; } = null!;


        [Required(ErrorMessage = "Nincs előadó hozzáadva!")]
        public int[] SelectedArtists { get; set; }



    }
}
