using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject1.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult CreationError()
        {
            string message = (string)Session["message"];
            return View(model: message);
        }
    }
}