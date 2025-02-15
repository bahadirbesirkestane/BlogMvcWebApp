using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        WriterManager _writerManager = new WriterManager(new EfWriterRepository());

        public IViewComponentResult Invoke()
        {
            return View();
        }

    
    }
}
