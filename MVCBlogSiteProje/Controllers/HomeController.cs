using MVCBlogSiteProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlogSiteProje.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext context = new DatabaseContext();
        public ActionResult Index()
        {
            var model = new HomePageViewModel()
            {


                Categories = context.Categories.ToList(),
                Posts = context.Posts.Where(p => p.IsActive && p.IsHome).ToList(),



            };
            return View(model);

        }
        public PartialViewResult KategorileriGetir()
        {
            var model = context.Categories.ToList();
            return PartialView("_PartialUstMenu", model);
        }


    }
}