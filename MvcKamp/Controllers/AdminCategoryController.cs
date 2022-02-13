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
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        private CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
       // [Authorize(Roles = "A")]
        public ActionResult Index()
        {
            var categoryValues = categoryManager.getList();
            return View(categoryValues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidatior = new CategoryValidator();
            ValidationResult results = categoryValidatior.Validate(category);
            if (results.IsValid)
            {
                categoryManager.add(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }

        public ActionResult DeleteCategory(int id)
        {
            var category = categoryManager.getById(id);
            categoryManager.delete(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var categoryValue = categoryManager.getById(id);
            return View(categoryValue);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            categoryManager.update(category);
            return RedirectToAction("Index");
        }
    }
}