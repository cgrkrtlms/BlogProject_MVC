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
    public class NewsLetterController : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EFNewsLetterRepository());
        
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter )
        {
            newsLetter.MailStatus = true;
            nlm.AddNewsLetter(newsLetter);
            return PartialView();
        }
    }
}
