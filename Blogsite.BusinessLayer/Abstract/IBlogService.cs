using Blogsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> GetBlogById(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWithWriter(int id);
        List<Blog> GetLastThreeBlogs();
        List<Blog> GetBlogListWithCategoryByWriter(int id);

    }
}
