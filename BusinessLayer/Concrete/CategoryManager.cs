using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> getList()
        {
            return _categoryDal.List();
        }

        public void add(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category getById(int id)
        {
            return _categoryDal.Get(x => x.CategoryId == id);
        }

        public void delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}

