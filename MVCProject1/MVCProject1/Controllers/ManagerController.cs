using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;
using System.Data.Entity;

namespace MVCProject1.Controllers
{
    public class ManagerController : Controller
    {
        private FilmsEntities1 db = new FilmsEntities1();

        // GET: Manager
        public ActionResult Index()
        {
            var films = db.Films.ToList();
            return View(films);
        }

        public ActionResult Create()
        {
            var film = new Film();
            return View(film);
        }

        public ActionResult Edit(Guid id)
        {
            var films = db.Films;
            var film = films.FirstOrDefault(p => p.FilmId == id);
            return View(film);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilmId,Name,Series,NumberofSeries,Year,Details,Genre")]Film film)
        {
            var films = new FilmsEntities1();
            var exists = films.Films.Any(b => b.Name.Equals(film.Name));
            //if(!exists)
            {
                try
                {
                    film.Available = true;
                    film.FilmId = Guid.NewGuid();
                    db.Films.Add(film);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Manager");
                }
                catch (Exception ex)
                {
                    Session["message"] = ex.Message;
                    return RedirectToAction("CreationError", "Error");
                }
                
            }
            //throw new Exception("Must create a new film.");
                
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Film film)
        {
            if(ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "Manager");
            }
            return View();
        }
    }
}