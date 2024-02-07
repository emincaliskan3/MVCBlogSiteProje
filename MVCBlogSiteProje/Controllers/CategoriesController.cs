﻿using MVCBlogSiteProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogSiteProje.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        DatabaseContext context = new DatabaseContext();

        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var data = context.Categories.Find(id);
            if (data == null)
            {
                return HttpNotFound();
            }
            return View(data);
        }
    }
}