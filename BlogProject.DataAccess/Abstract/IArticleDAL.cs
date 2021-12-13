using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Abstract
{
   public interface IArticleDAL:IGenericDAL<Article>
    {
        List<Article> GetListWithCategory();
        List<Article> GetListWithCategoryByWriter(int id);
        List<Article> GetListWithWriter(int id);
    }
}
