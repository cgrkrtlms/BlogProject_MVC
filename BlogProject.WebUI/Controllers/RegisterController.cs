using BlogProject.Business.Concrete;
using BlogProject.Business.Validation;
using BlogProject.DataAccess.EntityFramework;
using BlogProject.Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EFWriterRepository());
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator wv = new  WriterValidator();
            ValidationResult results = wv.Validate(writer);
            if (results.IsValid)
            {
                writer.Status = true;
                writer.About = "deneme text";
                writerManager.AddWriter(writer);
                return RedirectToAction("Index", "Article");
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
    }
}
