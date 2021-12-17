using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllNotification()
        {
            var values = nm.GetAll();
            return View(values);
        }
    }
}
