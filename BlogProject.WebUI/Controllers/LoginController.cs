using BlogProject.DataAccess.Concrete;
using BlogProject.Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            ProjectContext context = new ProjectContext();
            var data = context.Writers.FirstOrDefault(x => x.Email == writer.Email && x.Password == writer.Password);
            if (data!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.Email)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }

            else
            {
                return View();
            }
        }
    }
}

//ProjectContext context = new ProjectContext();
//var data = context.Writers.FirstOrDefault(x => x.Email == writer.Email && x.Password == writer.Password);
//if (data != null)
//{
//    HttpContext.Session.SetString("username", writer.Email);
//    return RedirectToAction("Index", "Writer");
//}
//return View();