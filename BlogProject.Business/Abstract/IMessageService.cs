using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Abstract
{
   public interface IMessageService:IGenericService<Message>
    {
        public List<Message> GetInboxListByWriter(string p);

    }
}
