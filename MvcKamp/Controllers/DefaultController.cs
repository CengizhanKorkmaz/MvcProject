using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;

namespace MvcKamp.Controllers
{
    public class DefaultController : Controller
    {
        private HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        private ContentManager contentManager = new ContentManager(new EfContentDal());

        // GET: Default
        public PartialViewResult Index(int id=0)
        {
            var contentList = contentManager.getListByHeadingId(id);
            return PartialView(contentList);
        }

        public ActionResult Headings()
        {
            var headingList = headingManager.getList();
            return View(headingList);
        }
    }
}