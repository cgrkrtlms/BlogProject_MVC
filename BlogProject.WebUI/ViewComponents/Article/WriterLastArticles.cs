using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents.Article
{
    public class WriterLastArticles:ViewComponent
    {
        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());
        public IViewComponentResult Invoke()
        {
            var values = articleManager.GetArticleListByWriter(3);
            return View(values);
        }
    }
}
