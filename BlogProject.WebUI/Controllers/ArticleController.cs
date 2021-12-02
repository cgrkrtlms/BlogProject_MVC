using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());
        public IActionResult Index()
        {
            var values = articleManager.GetAll();
            return View(values);
        }
    }
}
