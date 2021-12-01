using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
    public class Article
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }

        public string  Content { get; set; }

        public string ThumbnailImage { get; set; }

        public string Image { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }


        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
