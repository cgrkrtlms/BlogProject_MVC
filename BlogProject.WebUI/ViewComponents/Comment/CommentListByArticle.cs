using BlogProject.Business.Concrete;
using BlogProject.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents.Comment
{
    public class CommentListByArticle:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var comments = commentManager.GetAll(id);
            return View(comments);
        }
    }
}
