﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XePKL.Areas.Admin.Controllers
{
    public class CategroryController : Controller
    {
        // GET: Admin/Categrory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}