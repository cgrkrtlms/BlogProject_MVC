using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
   public class ArticleRayting
    {
        public int ArticleRaytingID { get; set; }

        public int ArticleID { get; set; }

        public int ArticleTotalScore { get; set; }

        public int ArticleRaytingCount { get; set; }


    }
}
