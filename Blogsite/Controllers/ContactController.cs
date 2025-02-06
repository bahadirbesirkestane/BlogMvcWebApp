using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Blogsite.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class ContactController : Controller
    {
        ContactManager _contactManager=new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;

            _contactManager.AddContact(contact);

            return RedirectToAction("Index","Blog");
        }
    }
}
