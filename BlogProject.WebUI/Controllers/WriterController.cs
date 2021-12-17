using BlogProject.Business.Concrete;
using BlogProject.Business.Validation;
using BlogProject.DataAccess.Concrete;
using BlogProject.DataAccess.EntityFramework;
using BlogProject.Entity.Concrete;
using BlogProject.WebUI.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
  
        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var userMail = User.Identity.Name;
            ProjectContext context = new ProjectContext();
            var writerID = context.Writers.Where(x => x.Email == userMail).Select(x => x.ID).FirstOrDefault();
            var values = wm.TGetById(writerID);
            return View(values);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);
            if (results.IsValid)
            {
                wm.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.Image!=null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFile/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                w.Image = newImageName;
            }
            w.Name = p.Name;
            w.Email = p.Email;
            w.Password = p.Password;
            w.Status = p.Status;
            w.About = p.About;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
