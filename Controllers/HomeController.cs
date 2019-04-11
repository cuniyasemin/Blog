using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogProject.Models;

namespace BlogProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Blog304DBEntities1 db = new Blog304DBEntities1();
        public ActionResult HomeIndex()
        {
            return View();
        }
        public ActionResult _PartialKategori()
        {
            return View(db.Kategoriler.ToList());
        }
    }
}