using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using BlogProject.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.Status = true;
            comment.ArticleID = 3;
            commentManager.AddComment(comment);
            return PartialView(comment);
        }
        public PartialViewResult CommentListByArticle(int id)
        {
           var value = commentManager.GetAll(id);
            return PartialView(value);
        }
    }
}
