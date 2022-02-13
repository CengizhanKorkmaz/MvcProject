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
    public class WriterManager:IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public List<Writer> getList()
        {
            return _writerDal.List();
        }

        public void add(Writer writer)
        {
            _writerDal.Add(writer);
        }

        public void update(Writer writer)
        {
            _writerDal.Update(writer);
        }

        public void delete(Writer writer)
        {
            _writerDal.Update(writer);
        }

        public Writer getById(int id)
        {
            return _writerDal.Get(x => x.WriterId == id);
        }
    }
}
