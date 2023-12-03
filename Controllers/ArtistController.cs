using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models.Objects;
using MusicLibrary.Models.ViewModel;

namespace artistLibrary.Controllers
{
    public class ArtistController : Controller
    {
        private DatabaseCtx dbCtx;
        public ArtistController(DatabaseCtx ctx) => dbCtx = ctx;






        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Artists = dbCtx.Artists.OrderBy(g => g.Name).ToList();

            var artistViewModel = new ArtistViewModel { artist = new Artist() };



            return View(artistViewModel);
        }



        [HttpPost]
        public IActionResult Add(ArtistViewModel artistViewModel)
        {
            ViewBag.Action = "Add";
            ViewBag.Artists = dbCtx.Artists.OrderBy(g => g.Name).ToList();


            Artist artist = artistViewModel.artist;

            if (ModelState.IsValid)
            {
                foreach (Artist artist_from_db in dbCtx.Artists)
                {
                    if (artist_from_db.Name == artistViewModel.artist.Name || artist_from_db.Id == artistViewModel.artist.Id) 
                    { 
                        artist = artist_from_db;
                        return RedirectToAction("Edit", "Artist", artist_from_db);
                    }
                }

                artist.Name = artistViewModel.artist.Name;

                System.Diagnostics.Debug.WriteLine("$$$ Artist Id: " + artist.Id);
                System.Diagnostics.Debug.WriteLine("$$$ Artist Name: " + artist.Name);



                dbCtx.Artists.Update(artist);
                dbCtx.SaveChanges();





                return RedirectToAction("Index", "Home");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("$$$ Modelstate is invalid.");
                return View(artistViewModel);

            }
        }





        [HttpGet]
        public IActionResult Edit(Artist artist_from_db)
        {
            ViewBag.Action = "Edit";

            var artistViewModel = new ArtistViewModel { artist = artist_from_db };



            return View(artistViewModel);
        }



        [HttpPost]
        public IActionResult Edit(ArtistViewModel artistViewModel)
        {
                Artist artist = artistViewModel.artist;


                artist.Name = artistViewModel.artist.Name;

                System.Diagnostics.Debug.WriteLine("$$$ Artist Id: " + artist.Id);
                System.Diagnostics.Debug.WriteLine("$$$ Artist Name: " + artist.Name);



                dbCtx.Artists.Update(artist);
                dbCtx.SaveChanges();





                return RedirectToAction("Index", "Home");
       
            
        }





        // delete
        [HttpGet]
        public ViewResult Delete(int Id)
        {
            ViewBag.Action = "Delete";

            Artist artist_with_id = null!;

            foreach (Artist artist in dbCtx.Artists.ToList())
            {
                if (artist.Id == Id) { artist_with_id = artist; break; }
            }

            System.Diagnostics.Debug.WriteLine("$$$ Artist Id: " + artist_with_id.Id);
            System.Diagnostics.Debug.WriteLine("$$$ Artist Name: " + artist_with_id.Name);





            var artistViewModel = new ArtistViewModel { artist = artist_with_id };



            return View(artistViewModel);
        }

        [HttpPost]
        public IActionResult Delete(Artist artist)
        {
            dbCtx.Artists.Remove(artist);
            dbCtx.SaveChanges();

            return RedirectToAction("Index", "Home");
        }











    }
}
