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

        public void AddWriter(Writer writer)
        {
            _writerDAL.Add(writer);
        }

    }
}
