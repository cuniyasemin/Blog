﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.Controllers
{
    public class ArchivesController : Controller
    {
        // GET: Archives
        public ActionResult ArchivesIndex()
        {
            return View();
        }
    }
}