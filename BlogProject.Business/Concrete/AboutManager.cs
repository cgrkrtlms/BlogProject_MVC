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
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;
        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }
        public List<About> GetAll()
        {
           return _aboutDAL.GetAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About entity)
        {
            throw new NotImplementedException();
        }
    }
}
