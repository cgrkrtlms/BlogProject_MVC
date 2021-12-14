using BlogProject.Business.Abstract;
using BlogProject.DataAccess.Abstract;
using BlogProject.DataAccess.EntityFramework;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void TAdd(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
