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
    public class Message2Manager : IMessage2Service
    {
        IMessage2DAL _messageDAL;
        public Message2Manager(IMessage2DAL messageDAL)
        {
            _messageDAL = messageDAL;
        }
        public List<Message2> GetAll()
        {
            return _messageDAL.GetAll();
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDAL.GetListWithMessageByWriter(id);
        }

        public void TAdd(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 entity)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
          return  _messageDAL.GetById(id);
        }

        public void TUpdate(Message2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
