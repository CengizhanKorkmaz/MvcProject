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
    [AllowAnonymous]
    public class AuthorizationController : Controller
    {
        private AdminManager adminManager = new AdminManager(new EfAdminDal());

        public ActionResult Index()
        {
            var adminValues = adminManager.getList();
            return View(adminValues);
        }
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin admin)
        {
            adminManager.add(admin);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAdmin(int id)
        {
            var adminValues = adminManager.getById(id);
            return View(adminValues);
        }

        [HttpPost]
        public ActionResult UpdateAdmin(Admin admin)
        {
            adminManager.update(admin);
            return RedirectToAction("Index");
        }
    }
}