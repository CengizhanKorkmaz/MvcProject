using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> getList();
        List<Heading> getListByWriter(int id);
        void add(Heading heading);
        void update(Heading heading);
        void delete(Heading heading);
        Heading getById(int id);
    }
}
