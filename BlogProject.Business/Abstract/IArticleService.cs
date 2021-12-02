using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Abstract
{
   public interface IArticleService
    {
        void AddArticle(Article article);
        void DeleteArticle(Article article);
        void UpdateArticle(Article article);
        List<Article> GetAll();

        Article GetById(int id);

        List<Article> GetArticleListWithCategory();
    }
}
