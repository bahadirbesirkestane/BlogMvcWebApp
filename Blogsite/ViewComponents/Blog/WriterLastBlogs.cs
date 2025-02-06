using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.ViewComponents.Blog
{
    public class WriterLastBlogs : ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            int id=2;

            var values = _blogManager.GetBlogListWithWriter(id);
            return View(values);
        }
    }
}
