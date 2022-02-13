using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> getList();
        void add(Contact contact);
        Contact getById(int id);
        void delete(Contact contact);
        void update(Contact contact);
    }
}
