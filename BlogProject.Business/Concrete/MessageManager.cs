using BlogProject.Business.Abstract;
using BlogProject.DataAccess.Abstract;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;
        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }
        public List<Message> GetAll()
        {
            return _messageDAL.GetAll();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDAL.GetAll(x=>x.Receiver==p);
        }

        public void TAdd(Message entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message entity)
        {
            throw new NotImplementedException();
        }

        public Message TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message entity)
        {
            throw new NotImplementedException();
        }
    }
}
