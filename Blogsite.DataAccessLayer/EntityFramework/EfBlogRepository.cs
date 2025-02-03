using Blogsite.DataAccessLayer.Abstract;
using Blogsite.DataAccessLayer.Concrete;
using Blogsite.DataAccessLayer.Repositories;
using Blogsite.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetListWithCategory()
        {
            using(var _context =new Context())
            {
                return _context.Blogs.Include(x => x.Category).ToList();
            }
            
        }
    }
}
