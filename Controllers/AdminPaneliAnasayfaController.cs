using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.Areas.AdminPaneli.Controllers
{
    public class AdminPaneliAnasayfaController : Controller
    {
        // GET: AdminPaneli/AdminPaneliAnasayfa
        public ActionResult AnasayfaIndex()
        {
            return View();
        }
    }
}