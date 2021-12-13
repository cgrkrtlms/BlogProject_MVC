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
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            var values = articleManager.GetArticleListWithWriter(id);
            return View();
        }
    }
}
