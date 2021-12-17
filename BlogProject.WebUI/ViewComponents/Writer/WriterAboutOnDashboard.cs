using BlogProject.Business.Concrete;
using BlogProject.DataAccess.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents.Writer
{
    public class WriterAboutOnDashboard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            ProjectContext context = new ProjectContext();
            var writerID = context.Writers.Where(x => x.Email == userMail).Select(x => x.ID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
