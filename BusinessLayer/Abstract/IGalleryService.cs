using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IGalleryService
    {
        void add(Gallery gallery);
        void delete(Gallery gallery);
        List<Gallery> geList();
    }
}
