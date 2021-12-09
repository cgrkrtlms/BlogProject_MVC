using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Abstract
{
   public interface IArticleService:IGenericService<Article>
    {
        List<Article> GetArticleListWithCategory();

        List<Article> GetArticleListByWriter(int id);
    }
}
