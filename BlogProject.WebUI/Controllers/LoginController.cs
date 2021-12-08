using BlogProject.DataAccess.Concrete;
using BlogProject.Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index(Writer writer)
        {
            ProjectContext context = new ProjectContext();
            var data = context.Writers.FirstOrDefault(x=>x.Email==writer.Email && x.Password==writer.Password);
            if (data!=null)
            {
                HttpContext.Session.SetString("username", writer.Email);
                return RedirectToAction("Index","Writer");
            }
            return View();
        }
    }
}
