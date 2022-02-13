using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class HeadingManager:IHeadingService
    {
        private IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }
        public List<Heading> getList()
        {
            return _headingDal.List();
        }

        public List<Heading> getListByWriter(int id)
        {
            return _headingDal.List(x=>x.WriterId==id);
        }

        public void add(Heading heading)
        {
            _headingDal.Add(heading);

        }

        public void update(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public void delete(Heading heading)
        {
            _headingDal.Update(heading);
        }

        public Heading getById(int id)
        {
            return _headingDal.Get(x => x.HeadingId == id);
        }
    }
}
