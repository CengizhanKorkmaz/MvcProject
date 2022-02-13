using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager:IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public List<Contact> getList()
        {
            return _contactDal.List();
        }

        public void add(Contact contact)
        {
            _contactDal.Add(contact);
        }

        public Contact getById(int id)
        {
            return _contactDal.Get(x=>x.ContactId==id);
        }

        public void delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public void update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
