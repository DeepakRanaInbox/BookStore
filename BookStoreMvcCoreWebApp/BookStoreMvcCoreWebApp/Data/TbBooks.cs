using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Data
{
    public class TbBooks
    {
        public int ID { get; set; }

        public string title { get; set; }

        public ICollection<BookGallery> bookGallery { get; set; }
        public string author { get; set; }

        public string discription { get; set; }
        public string imagePath { get; set; }

        public string category { get; set; }

        public string totalPages { get; set; }

        public string language { get; set; }

        public int MstLanguagesID { get; set; }
         
        public string bookpdfurl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
