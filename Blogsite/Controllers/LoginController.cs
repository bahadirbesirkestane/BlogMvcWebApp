using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
