using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcKamp.Controllers
{
    public class GalleryWebController : Controller
    {
        private GalleryManager galleryManager = new GalleryManager(new EfGalleryDal());
        // GET: GalleryWeb
        public ActionResult Index()
        {
            var galleryList = galleryManager.geList();
            return View(galleryList);
        }
        [HttpGet]
        public ActionResult AddGallery()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddGallery(Gallery gallery)
        {
            galleryManager.add(gallery);
            return RedirectToAction("Index");
        }
    }
}