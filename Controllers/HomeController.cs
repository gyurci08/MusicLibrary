using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models.Objects;
using System.Diagnostics;

namespace MusicLibrary.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseCtx dbCtx;
        public HomeController(DatabaseCtx ctx) => dbCtx = ctx;




        public IActionResult Index()
        {
            var music = dbCtx.Music.Include(m=>m.Artists).ToList();

            return View(music);
        }

    }
}