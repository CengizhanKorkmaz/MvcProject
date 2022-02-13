using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager:IAboutService
    {
        private IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void add(About about)
        {
           _aboutDal.Add(about);
        }

        public void delete(About about)
        {
            _aboutDal.Delete(about);
        }

        public About getById(int id)
        {
            return _aboutDal.Get(x=>x.AboutId==id);
        }

        public List<About> getList()
        {
            return _aboutDal.List();
        }

        public void update(About about)
        {
            _aboutDal.Update(about);
        }

    }
}
