using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;

namespace MvcProjeUI.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal());

        WriterValidator writervalidation = new WriterValidator();

        public ActionResult Index()
        {
            var writervalues = wm.GetList();
            return View(writervalues);
        }

        public ActionResult GetWriterList()
        {
            var writervalues = wm.GetList();
            return View(writervalues);
        }


        [HttpGet]
        public ActionResult AddWriter()
        {

            return View();
        }


        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {

            WriterValidator writervalidator = new WriterValidator();
            ValidationResult results = writervalidator.Validate(p);
            if (results.IsValid)//Geçerli ise 
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

    }
}