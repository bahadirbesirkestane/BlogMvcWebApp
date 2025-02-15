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
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void AddT(Blog t)
        {
            _blogDAL.Insert(t);
        }

        public void RemoveT(Blog t)
        {
            _blogDAL.Delete(t);
        }

        public void UpdateT(Blog t)
        {
            _blogDAL.Update(t);
        }

        public List<Blog> GetList()
        {
            return _blogDAL.GetAll();
        }

        public Blog TGetById(int id)
        {
            return _blogDAL.GetById(id);
        }

        public List<Blog> GetLastThreeBlogs()
        {
            return _blogDAL.GetAll().Take(3).ToList();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDAL.GetAll(x=>x.BlogId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public List<Blog> GetBlogListWithWriter(int id)
        {
            return _blogDAL.GetAll(x => x.WriterId == id);
        }

        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            return _blogDAL.GetListWithCategoryByWriter(id);
        }
    }
}
