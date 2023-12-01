using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;
using MusicLibrary.Models.Objects;
using System.Diagnostics;

namespace MusicLibrary.Controllers
{
    public class HomeController : Controller
    {

        private DatabaseContext dbContext { get; set; }  // Kell a db context

        public HomeController(DatabaseContext ctx)           // Konstruktor bekéri
        {
            dbContext = ctx;
        }


        public IActionResult Index()
        {
            List<Music> musics = dbContext.Musics.ToList();

            return View(musics);
        }




    }
}