using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> getList();
        Admin getById(int id);
        void add(Admin admin);
        void update(Admin admin);
        void delete(Admin admin);
    }
}
