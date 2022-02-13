    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
    using BusinessLayer.Concrete;
    using DataAccessLayer.EntityFramework;

    namespace MvcKamp.Controllers
{
    public class GalleryController : Controller
    {
        private ImageFileManager imageFileManager = new ImageFileManager(new EfImageFileDal());
        // GET: Gallery
        public ActionResult Index()
        {
            var imageFiles = imageFileManager.getList();
            return View(imageFiles);
        }
    }
}