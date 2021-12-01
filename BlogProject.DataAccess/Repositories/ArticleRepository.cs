using BlogProject.DataAccess.Abstract;
using BlogProject.DataAccess.Concrete;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Repositories
{
    public class ArticleRepository : IArticleDAL
    {

        public void AddCategory(Article article)
        {
            using var context = new ProjectContext();
            context.Add(article);
            context.SaveChanges();
        }
        public void DeleteCategory(Article article)
        {
            using var context = new ProjectContext();
            context.Remove(article);
            context.SaveChanges();
        }

        public List<Article> GetAllCategory()
        {
            using var context = new ProjectContext();
            return context.Articles.ToList();
        }

        public Article GetById(int id)
        {
            using var context = new ProjectContext();
            return context.Articles.Find(id);
        }

        public void UpdateCategory(Article article)
        {
            using var context = new ProjectContext();
            context.Update(article);
            context.SaveChanges();
        }
    }
}
