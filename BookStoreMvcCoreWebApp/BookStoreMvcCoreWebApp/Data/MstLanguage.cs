using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Data
{
    public class MstLanguages
    {
        public int ID { get; set; }
        public string vName { get; set; }
        public string vDiscription { get; set; }

        public ICollection<TbBooks> TbBooks { get; set; }
       

    }
}
