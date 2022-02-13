using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public  class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        [StringLength(300)]
        public string GalleryPath { get; set; }
    }
}
