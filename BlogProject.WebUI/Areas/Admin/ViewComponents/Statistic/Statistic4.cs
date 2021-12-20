using BlogProject.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        ProjectContext context = new ProjectContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Admins.Where(x => x.ID == 1).Select(x => x.Name).FirstOrDefault();
            ViewBag.v2 = context.Admins.Where(x => x.ID == 1).Select(x => x.ImageUrl).FirstOrDefault();
            ViewBag.v3 = context.Admins.Where(x => x.ID == 1).Select(x => x.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
