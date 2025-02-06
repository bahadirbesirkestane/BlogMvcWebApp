using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Blogsite.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager _newsManager = new NewsLetterManager(new EfNewsLetterRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubscribeMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            _newsManager.AddNewsLetter(newsLetter);

            return RedirectToAction("Index","Blog");
        }
    }
}
