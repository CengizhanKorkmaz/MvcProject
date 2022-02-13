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
    public class ContentManager:IContentService
    {
        private IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public List<Content> getList(string search)
        {
            return _contentDal.List(x=>x.ContentValue.Contains(search));
        }

        public List<Content> getListAll()
        {
            return _contentDal.List();
        }

        public void add(Content content)
        {
            _contentDal.Add(content);
        }

        public void update(Content content)
        {
            _contentDal.Update(content);
        }

        public void delete(Content content)
        {
           _contentDal.Delete(content);
        }

        public Content getById(int id)
        {
            return _contentDal.Get(x=>x.ContentId==id);
        }

        public List<Content> getListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }

        public List<Content> getListByWriterId(int id)
        {
            return _contentDal.List(x => x.WriterId == id);
        }
    }
}
