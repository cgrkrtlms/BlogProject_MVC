using BlogProject.Business.Concrete;
using BlogProject.DataAccess.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            string api = "b8a6592a11977877fc9b01b3ea3f7b43";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
