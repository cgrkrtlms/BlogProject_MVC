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
   public class WriterManager:IWriterService
    {
        IWriterDAL _writerDAL; 
        public WriterManager(IWriterDAL writerDAL )
        {
            _writerDAL = writerDAL;
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
           return  _writerDAL.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDAL.GetAll(x=>x.ID==id);
        }

        public void TAdd(Writer entity)
        {
            _writerDAL.Add(entity);
        }

        public void TDelete(Writer entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer entity)
        {
            _writerDAL.Update(entity);
        }
    }
}
