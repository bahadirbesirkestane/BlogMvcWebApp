using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Blogsite.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            int writerId = 3;

            var values = _blogManager.GetBlogListWithCategory().OrderByDescending(x => x.BlogId).Take(10).ToList();

            return View(values);
        }
    }
}
