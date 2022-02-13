using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcKamp.Controllers
{
    public class WriterPanelContentController : Controller
    {
        private ContentManager contentManager = new ContentManager(new EfContentDal());
        Context context = new Context();
        // GET: WriterPanelContent
        public ActionResult MyContent(string p)
        {
            
            p=(string)Session["WriterMail"];
            var writerId = context.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterId).FirstOrDefault();
            var contentValues = contentManager.getListByWriterId(writerId);
            return View(contentValues);
        }
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content content)
        {
            string mail = (string)Session["WriterMail"];
            content.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            var writerId = context.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterId).FirstOrDefault();
            content.WriterId = writerId;
            content.ContentStatus = true;
            contentManager.add(content);
            return RedirectToAction("MyContent");
            
        }

        public ActionResult ToDoList()
        {
            return View();
        }
    }
}