using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> getList();
        void add(Writer writer);
        void update(Writer writer);
        void delete(Writer writer);
        Writer getById(int id);
    }
}
