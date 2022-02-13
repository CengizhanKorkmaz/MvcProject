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
    public class GalleryManager:IGalleryService
    {
        private IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }
        public void add(Gallery gallery)
        {
            _galleryDal.Add(gallery);
        }

        public void delete(Gallery gallery)
        {
            _galleryDal.Delete(gallery);
        }

        public List<Gallery> geList()
        {
            return _galleryDal.List();
        }
    }
}
