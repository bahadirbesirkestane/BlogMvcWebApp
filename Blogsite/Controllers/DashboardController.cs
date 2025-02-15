using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
