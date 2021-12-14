using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            ViewBag.v1 = articleManager.GetAll().Count();
            ViewBag.v2 = articleManager.GetArticleListByWriter(3).Count();
            ViewBag.v3 = categoryManager.GetAll().Count();
            var values = articleManager.GetArticleListWithWriter(id);
            return View();
        }
    }
}
