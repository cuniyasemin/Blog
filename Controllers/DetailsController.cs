using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult DetailsIndex()
        {
            return View();
        }
    }
}