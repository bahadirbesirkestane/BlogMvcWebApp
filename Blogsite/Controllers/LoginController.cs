using Blogsite.DataAccessLayer.Concrete;
using Blogsite.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Blogsite.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            Context _context = new Context();

            var dataValue = _context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);

            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterMail)
                };

                var userIdentity= new ClaimsIdentity(claims,"a");
                ClaimsPrincipal user = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(user);

                return  RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }


            
            //Context _context = new Context();

            //var dataValue = _context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);


            //if (dataValue != null)
            //{
            //    HttpContext.Session.SetString("username", writer.WriterMail);
            //    return RedirectToAction("Index", "Writer");
            //}
            //else
            //{
            //    return View();
            //}


        }
    }
}
