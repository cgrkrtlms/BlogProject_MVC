using BlogProject.DataAccess.Abstract;
using BlogProject.DataAccess.Concrete;
using BlogProject.DataAccess.Repositories;
using BlogProject.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.EntityFramework
{
    public class EFArticleRepository : GenericRepository<Article>, IArticleDAL
    {
        public List<Article> GetListWithCategory()
        {
            using (var context = new ProjectContext())
            {
                return context.Articles.Include(x => x.Category).ToList();
            }
        }

        public List<Article> GetListWithCategoryByWriter(int id)
        {
            using (var context = new ProjectContext())
            {
                return context.Articles.Include(x => x.Category).Where(x=>x.WriterID==id).ToList();
            }
        }

        public List<Article> GetListWithWriter(int id)
        {
            using (var context = new ProjectContext())
            {
                return context.Articles.Include(x => x.Writer).Where(x => x.WriterID == id).ToList();
            }
        }
    }
}
