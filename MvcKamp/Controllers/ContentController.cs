using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcKamp.Controllers
{
    public class ContentController : Controller
    {
        private ContentManager contentManager = new ContentManager(new EfContentDal());

        // GET: Content
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentValues = contentManager.getListByHeadingId(id);
            return View(contentValues);
        }

        public ActionResult GetAllContent(string search)
        {
            var values = contentManager.getListAll();
            if (!string.IsNullOrEmpty(search))
            {
                values = contentManager.getList(search);
            }
           
            return View(values);
        }
    }
}