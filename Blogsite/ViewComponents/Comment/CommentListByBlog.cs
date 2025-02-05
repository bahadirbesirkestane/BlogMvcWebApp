using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager _commentManager=new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.GetAll(id);
            return View(values);
        }
    }
}
