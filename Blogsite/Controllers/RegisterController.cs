using Blogsite.BusinessLayer.Concrete;
using Blogsite.BusinessLayer.ValidationRules;
using Blogsite.DataAccessLayer.EntityFramework;
using Blogsite.EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager _writerManager= new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator valRules = new WriterValidator();

            ValidationResult results = valRules.Validate(writer);

            if(results.IsValid)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Dene";

                _writerManager.AddWriter(writer);

                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

    }
}
