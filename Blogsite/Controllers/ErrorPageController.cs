using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {            
            return View();
        }
    }
}
