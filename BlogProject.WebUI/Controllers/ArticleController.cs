using BlogProject.Business.Concrete;
using BlogProject.Business.Validation;
using BlogProject.DataAccess.EntityFramework;
using BlogProject.Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ArticleController : Controller
    {
        ArticleManager articleManager = new ArticleManager(new EFArticleRepository());

        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            var values = articleManager.GetArticleListWithCategory();
            return View(values);
        }

        public IActionResult ArticleDetails(int id)
        {
            ViewBag.i = id;
            var value = articleManager.GetArticleByID(id);
            return View(value);
        }
        public IActionResult ArticleListByWriter()
        {
            var values = articleManager.GetListWithCategoryByWriterArticleManager(3);
            return View(values);
        }

        public IActionResult AddArticle()
        {
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.ID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult AddArticle(Article article)
        {
            ArticleValidator av = new ArticleValidator();
            ValidationResult results = av.Validate(article);
            if (results.IsValid)
            {
                article.Status = true;
                article.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                article.WriterID = 3;
                articleManager.TAdd(article);
                return RedirectToAction("ArticleListByWriter", "Article");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult ArticleDelete(int id)
        {
            var blogValue = articleManager.TGetById(id);
            articleManager.TDelete(blogValue);
            return RedirectToAction("ArticleListByWriter");
        }
        public IActionResult ArticleUpdate(int id)
        {
            var article = articleManager.TGetById(id);
            List<SelectListItem> categoryValues = (from x in cm.GetAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name,
                                                       Value = x.ID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            return View(article);
        }
        [HttpPost]
        public IActionResult ArticleUpdate(Article article)
        {
            //var blogValue = articleManager.GetById(article.ID);
            //article.CreateDate = DateTime.Parse(blogValue.CreateDate.ToShortDateString());
            //ViewBag.createDate = article.CreateDate;
            article.WriterID = 3;
            article.Status = true;

            articleManager.TUpdate(article);
            return RedirectToAction("ArticleListByWriter");
        }

    }
}
