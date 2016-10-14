using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject1.Models;

namespace MVCProject1.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult CreationError()
        {
            var film = Session["film"];
            return View(film);
        }

        [HttpPost]
        public ActionResult CreationError(Film film)
        {
            return RedirectToAction("CreateFilm", "Manager", film); 
        }

    }
}