using Blogsite.DataAccessLayer.Abstract;
using Blogsite.DataAccessLayer.Repositories;
using Blogsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDAL
    {
    }
}
