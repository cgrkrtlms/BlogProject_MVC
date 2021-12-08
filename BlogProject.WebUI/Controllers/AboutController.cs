﻿using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EFAboutRepository());

        public IActionResult Index()
        {
            var values = aboutManager.GetAll();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout() 
        {
          
            return PartialView();
        }
    }
}
