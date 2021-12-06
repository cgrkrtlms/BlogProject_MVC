using BlogProject.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.WebUI.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            var comments = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Çağrı"
                },
                new UserComment
                {
                    ID=2,
                    Username="Ayşe"
                },
                new UserComment
                {
                    ID=3,
                    Username="Merve"
                }
            };
            return View(comments);
        }
    }
}
