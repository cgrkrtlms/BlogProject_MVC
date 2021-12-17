﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entity.Concrete
{
   public class Message2
    {
        [Key]
        public int ID { get; set; }

        public int? SenderID { get; set; }

        public int? ReceiverID { get; set; }

        public string Subject { get; set; }

        public string MessageDetails { get; set; }

        public DateTime MessageDate { get; set; }
        public bool MessageStatus { get; set; }


        public Writer SenderUser { get; set; }
        public Writer ReceiverUser { get; set; }
    }
}