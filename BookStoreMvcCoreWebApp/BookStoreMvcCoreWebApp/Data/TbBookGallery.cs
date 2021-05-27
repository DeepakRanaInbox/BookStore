using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Data
{
    public class BookGallery
    {
        public int ID { get; set; }

        public int BookID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public TbBooks Books { get; set; }

    }
}
