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

        public void AddCategory(Category category)
        {
            _categoryDAL.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDAL.Delete(category);
        }

        public List<Category> GetAll()
        {
           return _categoryDAL.GetAll().ToList();
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryDAL.Update(category);
        }
    }
}
