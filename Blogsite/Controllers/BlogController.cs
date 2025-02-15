using Blogsite.BusinessLayer.Concrete;
using Blogsite.BusinessLayer.ValidationRules;
using Blogsite.DataAccessLayer.EntityFramework;
using Blogsite.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogsite.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();

            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.BlogId = id;
            
            var values =_blogManager.GetBlogById(id);

            var blog =values.Find(x => x.BlogId == id);
            ViewBag.WriterId = blog.WriterId;

            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            int writerId = 3;

            var values = _blogManager.GetBlogListWithCategoryByWriter(writerId);


            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> categoryValue = (from x in _categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                      
                                                  }).ToList();
            ViewBag.CategoryValue = categoryValue;

            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            BlogValidator valRules = new BlogValidator();

            ValidationResult results = valRules.Validate(blog);

            if(results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterId = 3;
                blog.BlogThumbnailImage = blog.BlogImage;


                _blogManager.AddT(blog);
                return RedirectToAction("BlogListByWriter");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            List<SelectListItem> categoryValue = (from x in _categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()

                                                  }).ToList();
            ViewBag.CategoryValue = categoryValue;

            return View();

           
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogValue=_blogManager.TGetById(id);
            _blogManager.RemoveT(blogValue);
            return RedirectToAction("BlogListByWriter");
        }

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categoryValue = (from x in _categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()

                                                  }).ToList();
            ViewBag.CategoryValue = categoryValue;

            var blogValue = _blogManager.TGetById(id);
            return View(blogValue);
        }

        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            BlogValidator valRules = new BlogValidator();

            ValidationResult results = valRules.Validate(blog);

            var blogValue = _blogManager.TGetById(blog.BlogId);

            if (results.IsValid)
            {
                blogValue.BlogTitle=blog.BlogTitle;
                blogValue.BlogContent=blog.BlogContent;
                blogValue.BlogThumbnailImage=blog.BlogThumbnailImage;
                blogValue.BlogImage=blog.BlogImage;
                blogValue.CategoryId=blog.CategoryId;

                _blogManager.UpdateT(blogValue);

                return RedirectToAction("BlogListByWriter");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            List<SelectListItem> categoryValue = (from x in _categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()

                                                  }).ToList();
            ViewBag.CategoryValue = categoryValue;

            
            return View(blogValue);


        }

    }
}
