using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcKamp.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HomePage()
        {
            var galleryList = galleryManager.geList();
            return View(galleryList);
        }
    }
}