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
    public class AdminManager : IAdminService
    {
        IAdminDAL _adminDal;
        public AdminManager(IAdminDAL adminDal)
        {
            _adminDal = adminDal;
        }
        public List<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Admin entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Admin TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
