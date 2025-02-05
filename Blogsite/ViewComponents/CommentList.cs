using Blogsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogsite.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName="Badko"
                },
                new UserComment
                {
                    Id = 2,
                    UserName="Beşir"
                },
                new UserComment
                {
                    Id = 3,
                    UserName="Ksstane"
                }
            };

            return View(commentValues);
        }
    }
}
