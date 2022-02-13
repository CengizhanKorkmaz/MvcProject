using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;

namespace MvcKamp.Controllers
{
    public class MessageController : Controller
    {
        private MessageManager messageManager = new MessageManager(new EfMessageDal());

        private MessageValidator messageValidator = new MessageValidator();
        // GET: Message
        //[Authorize(Roles = "B")]
        public ActionResult Inbox(string mail)
        {
            var messageList = messageManager.getListInbox(mail);
            return View(messageList);
        }

        public ActionResult SendBox(string mail)
        {
            var messageList = messageManager.getListSendBox(mail);
            return View(messageList);
        }
        [HttpGet]
      
        public ActionResult GetInboxMessageDetails(int id)
        {
            var messageValues = messageManager.getById(id);
            return View(messageValues);

        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var messageValues = messageManager.getById(id);
            return View(messageValues);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            ValidationResult results = messageValidator.Validate(message);
            if (results.IsValid)
            {
                message.MessageDate=DateTime.Parse(DateTime.Now.ToShortDateString().ToString());
                messageManager.add(message);
                return RedirectToAction("SendBox");
            }
            else
            {
                foreach (var item in results.Errors )
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);

                }
            }

            return View();
        }
      
    }
}