using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class AboutController : Controller
    {
        AboutManager _aboutManager= new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values=_aboutManager.GetAll();

            return View(values);
        }

        public PartialViewResult SocialMediaPartial()
        {
            return PartialView();
        }
    }
}
