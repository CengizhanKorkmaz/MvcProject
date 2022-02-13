using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace MvcKamp.Controllers
{
    public class ContactController : Controller
    {
         ContactManager contactManager = new ContactManager(new EfContactDal());

         ContactValidator contactValidator = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            
            var contactValues = contactManager.getList();
            return View(contactValues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.getById(id);
            return View(contactValues);
            
        }

        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
    }
}