using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id=3;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}
