﻿using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = categoryManager.GetAll();
            return View(values);
        }
    }
}