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
   public class EFMessage2Repository:GenericRepository<Message2>,IMessage2DAL
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var context = new ProjectContext())
            {
                return context.Message2s.Include(x => x.SenderUser).Where(x => x.ReceiverID == id).ToList();
            }
        }
    }
}
