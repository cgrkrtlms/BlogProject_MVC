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
    public class ArticleManager : IArticleService
    {
        IArticleDAL _articleDAL;

        public ArticleManager(IArticleDAL articleDAL)
        {
            _articleDAL = articleDAL;
        }

        public void AddArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public void DeleteArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAll()
        {
            return _articleDAL.GetAll();
        }

        public List<Article> GetArticleListWithCategory()
        {
            return _articleDAL.GetListWithCategory();
        }

        public List<Article> GetArticleByID(int id)
        {
            return _articleDAL.GetAll(x=>x.ID==id);
        }
        public Article GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateArticle(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
