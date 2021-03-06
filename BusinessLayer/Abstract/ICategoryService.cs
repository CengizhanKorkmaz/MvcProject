using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category>getList();
        void add(Category category);
        Category getById(int id);
        void delete(Category category);
        void update(Category category);
    }
}
