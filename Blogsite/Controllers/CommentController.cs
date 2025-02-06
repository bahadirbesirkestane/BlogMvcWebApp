using Blogsite.BusinessLayer.Concrete;
using Blogsite.DataAccessLayer.EntityFramework;
using Blogsite.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment,int blogId)
         {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;

            comment.BlogId= blogId;

            _commentManager.AddComment(comment);

            return RedirectToAction("BlogReadAll","Blog", new { id = blogId });
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogId = 6;

            _commentManager.AddComment(comment);

            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = _commentManager.GetAll(id);
            return PartialView(values);
        }
    }
}
