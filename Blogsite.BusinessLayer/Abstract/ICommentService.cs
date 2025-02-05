using Blogsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);
        //void RemoveComment(Comment comment);
        //void UpdateComment(Comment comment);
        List<Comment> GetAll(int id);
        //Comment GetById(int id);

    }
}
