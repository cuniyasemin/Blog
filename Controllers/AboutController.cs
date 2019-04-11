using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult AboutIndex()
        {
            return View();
        }
    }
}