using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.GetAll();
            return View(values);
        }
    }
}
