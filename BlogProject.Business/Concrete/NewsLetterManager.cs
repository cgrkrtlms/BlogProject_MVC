using BlogProject.Business.Abstract;
using BlogProject.DataAccess.Abstract;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDAL _newsLetterDAL;
        public NewsLetterManager(INewsLetterDAL newsLetterDAL)
        {
            _newsLetterDAL = newsLetterDAL;
        }
        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetterDAL.Add(newsLetter);
        }
    }
}
