using Blogsite.BusinessLayer.Abstract;
using Blogsite.DataAccessLayer.Abstract;
using Blogsite.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogsite.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void AddT(About t)
        {
            throw new NotImplementedException();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDAL.GetAll();
        }

        public void RemoveT(About t)
        {
            throw new NotImplementedException();
        }

        public void UpdateT(About t)
        {
            throw new NotImplementedException();
        }
    }
}
