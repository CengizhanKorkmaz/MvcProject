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
    public class AdminManager:IAdminService
    {
        private IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }
        public List<Admin> getList()
        {
            return _adminDal.List();
        }

        public Admin getById(int id)
        {
            return _adminDal.Get(x=>x.Id==id);
        }

        public void add(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void update(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public void delete(Admin admin)
        {
            _adminDal.Delete(admin);
        }
    }
}
