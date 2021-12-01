using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
   public class Contact
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public DateTime ContactDate { get; set; }

        public bool Status { get; set; }


    }
}
