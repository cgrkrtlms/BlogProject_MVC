using BlogProject.Business.Concrete;
using BlogProject.DataAccess.Concrete;
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
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());

        public IActionResult Inbox()
        {
                int id = 3;
                var values = mm.GetInboxListByWriter(id);
                return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var value = mm.TGetById(id);
            return View(value);
        }
    }

}
