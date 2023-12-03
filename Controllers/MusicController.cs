using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models.Objects;
using MusicLibrary.Models.ViewModel;

namespace MusicLibrary.Controllers
{
    public class MusicController : Controller
    {

        private DatabaseCtx dbCtx;
        public MusicController(DatabaseCtx ctx) => dbCtx = ctx;





        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            
            ViewBag.Artists = dbCtx.Artists.OrderBy(g => g.Name).ToList();

            Music music_with_id=null!;

            foreach(Music music in dbCtx.Music.Include(m=>m.Artists).ToList())
            {
                if(music.Id == id) { music_with_id = music; break; }
            }


            var musicViewModel = new MusicViewModel { music = music_with_id };



            return View(musicViewModel);
        }


        [HttpPost]
        public IActionResult Edit(MusicViewModel musicViewModel)
        {
            if (ModelState.IsValid)
            {
                Music music = null!;

                foreach (Music music_from_db in dbCtx.Music.Include(m => m.Artists).ToList())
                {
                    if (music_from_db.Id == musicViewModel.music.Id) { music = music_from_db; break; }
                }

                music.Title = musicViewModel.music.Title;
                music.Year = musicViewModel.music.Year;



                System.Diagnostics.Debug.WriteLine("$$$ Music ID: " + music.Id);
                System.Diagnostics.Debug.WriteLine("$$$ Music Title: " + music.Title);
                System.Diagnostics.Debug.WriteLine("$$$ Music artist count: " + music.Artists.Count());
                

                foreach (Artist artist in music.Artists)
                {
                    music.Artists.Remove(artist);
                }
                


                foreach (int Id in musicViewModel.SelectedArtists)
                {
                    Artist? artist = dbCtx.Artists.Find(Id);

                    if (artist != null)
                    {
                        music.Artists.Add(artist);
                    }
                }
                System.Diagnostics.Debug.WriteLine("$$$ Artist count after add : " + music.Artists.Count);



                foreach (Artist artist in music.Artists)
                {
                    System.Diagnostics.Debug.WriteLine("$$$ Artist added: " + artist.Name);
                }

              
                dbCtx.Music.Update(music);
                dbCtx.SaveChanges();
               


                

                return RedirectToAction("Index", "Home");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("$$$ Modelstate is invalid.");
                return RedirectToAction("Edit", "Music");
   
            }
        }


        // delete
        [HttpGet]
        public ViewResult Delete(int id)
        {
            ViewBag.Action = "Delete";

            Music music_with_id = null!;

            foreach (Music music in dbCtx.Music.Include(m => m.Artists).ToList())
            {
                if (music.Id == id) { music_with_id = music; break; }
            }


            var musicViewModel = new MusicViewModel { music = music_with_id };



            return View(musicViewModel);
        }

        [HttpPost]
        public IActionResult Delete(Music music)
        {
            dbCtx.Music.Remove(music); 
            dbCtx.SaveChanges();

            return RedirectToAction("Index", "Home");
        }




        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            ViewBag.Artists = dbCtx.Artists.OrderBy(g => g.Name).ToList();


            var musicViewModel = new MusicViewModel { music = new Music() };



            return View(musicViewModel);
        }



        [HttpPost]
        public IActionResult Add(MusicViewModel musicViewModel)
        {
            if (ModelState.IsValid)
            {
                Music music = musicViewModel.music;

                System.Diagnostics.Debug.WriteLine("$$$ Music Title: " + music.Title);
                System.Diagnostics.Debug.WriteLine("$$$ Music artist count: " + music.Artists.Count());


                foreach (int Id in musicViewModel.SelectedArtists)
                {
                    Artist? artist = dbCtx.Artists.Find(Id);

                    if (artist != null)
                    {
                        music.Artists.Add(artist);
                    }
                }
                System.Diagnostics.Debug.WriteLine("$$$ Artist count after add : " + music.Artists.Count);



                foreach (Artist artist in music.Artists)
                {
                    System.Diagnostics.Debug.WriteLine("$$$ Artist added: " + artist.Name);
                }


                dbCtx.Music.Update(music);
                dbCtx.SaveChanges();





                return RedirectToAction("Index", "Home");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("$$$ Modelstate is invalid.");
                return RedirectToAction("Add", "Music");

            }
        }









    }
}
