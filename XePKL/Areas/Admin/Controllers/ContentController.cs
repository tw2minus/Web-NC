﻿using Modell.Dao;
using Modell.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XePKL.Areas.Admin.Controllers
{
    public class ContentController : BaseController
    {
        // GET: Admin/Content
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(long id)
        {
            var dao = new ContentDao();
            var content = dao.GetByID(id);
            SetViewBag(content.CategoryID);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Content model)
        {
            if (ModelState.IsValid)
            {

            }
            SetViewBag(model.CategoryID);
            return View();
        }

        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Content model)
        {
            if (ModelState.IsValid)
            {

            }
            SetViewBag();
            return View();
        }

        public void SetViewBag(long? selectedId = null)
        {
            var dao = new CategroryDao();
            ViewBag.CategoryID = new SelectList(dao.ListAll(), "ID", "Name", selectedId);
        }
    }
}