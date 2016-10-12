    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;
using System.Data.Entity;

namespace MVCProject1.Controllers
{
    public class HomeController : Controller
    {
        private FilmsEntities1 db = new FilmsEntities1();
        // GET: Home
        public ActionResult Index()
        {
            var films = FilmManager.GetFilms().FindAll(p => p.Available == true);
            return View(films);
        }

        public ActionResult Details(Guid id)
        {
            var films = FilmManager.GetFilms();
            var film = films.Find(p => p.FilmId == id);
            return View(film);
        }

        public ActionResult Genre(string genre)
        {
            var films = FilmManager.GetFilms();
            var filmGenre = films.FindAll(p => p.Genre == genre);
            return View(filmGenre);
        }

        public ActionResult Series(string series)
        {
            var films = FilmManager.GetFilms();
            var filmSeries = films.FindAll(p => p.Series == series);
            return View(filmSeries);
        }

        [HttpPost]
        public ActionResult Details(Film film)
        {
            if(ModelState.IsValid)
            {
                var movie = db.Films.FirstOrDefault(p => p.FilmId == film.FilmId);
                movie.Available = false;
                //db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
            }
            
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public string Sort()
        {
            string result = "";
            var titles = db.Films.OrderBy(b => b.Name).ToList();
            return result;
        }



    }
}