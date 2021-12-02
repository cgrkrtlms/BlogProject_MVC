using BlogProject.DataAccess.Abstract;
using BlogProject.DataAccess.Concrete;
using BlogProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        ProjectContext context = new ProjectContext();

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
            context.Add(category);
            context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            context.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategory()
        {
            return context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return context.Categories.Find(id);
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            context.Update(category);
            context.SaveChanges();
        }
    }
}
