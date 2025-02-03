using Blogsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);
        void RemoveBlog(Blog blog);
        void UpdateBlog(Blog blog);
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
    }
}
