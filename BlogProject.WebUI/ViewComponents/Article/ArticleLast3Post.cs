using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents.Article
{
    public class ArticleLast3Post:ViewComponent
    {

        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());
        public IViewComponentResult Invoke()
        {
            var values = articleManager.GetLast3Article();
            return View(values);
        }
    }
}
