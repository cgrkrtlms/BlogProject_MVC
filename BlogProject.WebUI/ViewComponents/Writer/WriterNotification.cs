using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager notificationManager = new NotificationManager(new EFNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = notificationManager.GetAll().Where(x=>x.Status==true).ToList();
            return View(values);
        }
    }
}
