using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();

            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.BlogId = id;
            var values =_blogManager.GetBlogById(id);
            return View(values);
        }
    }
}
