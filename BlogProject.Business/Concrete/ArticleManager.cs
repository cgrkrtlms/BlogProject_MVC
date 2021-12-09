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


        public List<Article> GetAll()
        {
            return _articleDAL.GetAll();
        }

        public List<Article> GetLast3Article() 
        {
            return _articleDAL.GetAll().Take(3).ToList();
        }
        public List<Article> GetArticleListWithCategory()
        {
            return _articleDAL.GetListWithCategory();
        }
        public List<Article> GetListWithCategoryByWriterArticleManager(int id)
        {
            return _articleDAL.GetListWithCategoryByWriter(id);
        }
        public List<Article> GetArticleByID(int id)
        {
            return _articleDAL.GetAll(x=>x.ID==id);
        }
        public Article GetById(int id)
        {
            return _articleDAL.GetById(id);
        }


        public List<Article> GetArticleListByWriter(int id)
        {
            return _articleDAL.GetAll(x=>x.WriterID==id);
        }

        public void TAdd(Article entity)
        {
            _articleDAL.Add(entity);
        }

        public void TDelete(Article entity)
        {
            _articleDAL.Delete(entity);
        }

        public void TUpdate(Article entity)
        {
            throw new NotImplementedException();
        }
    }
}
