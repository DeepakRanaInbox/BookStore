using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Models
{
    public class Book_Model
    {
        public int ID { get; set; }

        public string title { get; set; }

        public string author { get; set; }

        public string discription { get; set; }
        public string imagePath { get; set; }

        public string category { get; set; }

        public string totalPages { get; set; }

        public string language { get; set; }

        public List<Book_Model> similerBooks { get; set; }
    }
}
