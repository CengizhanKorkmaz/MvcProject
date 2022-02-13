using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> getList(string p);
        List<Content> getListAll();
        void add(Content content);
        void update(Content content);
        void delete(Content content);
        Content getById(int id);
        List<Content> getListByHeadingId(int id);
        List<Content> getListByWriterId(int id);
    }
}
