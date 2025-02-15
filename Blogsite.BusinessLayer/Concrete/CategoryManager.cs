using Blogsite.BusinessLayer.Abstract;
using Blogsite.DataAccessLayer.Abstract;
using Blogsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void AddT(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public Category TGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDAL.GetAll();
        }

        public void RemoveT(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public void UpdateT(Category t)
        {
            _categoryDAL.Update(t);
        }
        
    }
}
