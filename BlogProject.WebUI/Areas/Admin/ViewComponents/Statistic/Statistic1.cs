using BlogProject.Business.Concrete;
using BlogProject.DataAccess.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());
        ProjectContext context = new ProjectContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = articleManager.GetAll().Count();
            ViewBag.v2 = context.Contacts.Count();
            ViewBag.v3 = context.Comments.Count();
            return View();
        }
    }
}
