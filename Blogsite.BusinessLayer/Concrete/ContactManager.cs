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
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }
        public void AddContact(Contact contact)
        {
            _contactDAL.Insert(contact);
        }
    }
}
