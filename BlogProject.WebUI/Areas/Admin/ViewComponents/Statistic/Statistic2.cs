using BlogProject.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        ProjectContext context = new ProjectContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Articles.OrderByDescending(x => x.ID).Select(x => x.Title).Take(1).FirstOrDefault();
            return View();
        }
    }
}
