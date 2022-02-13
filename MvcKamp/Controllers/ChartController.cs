using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcKamp.Models;

namespace MvcKamp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet);
        }

        public List<Category> BlogList()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category()
            {
                CategoryName = "Yazılım",
                CategoryCount =8
            });
            categories.Add(new Category()
            {
                CategoryName = "Elektronik",
                CategoryCount = 10
            });
            categories.Add(new Category()
            {
                CategoryName = "İnşaat",
                CategoryCount = 12
            });
            return categories;
        }
    }
}