using BookStoreMvcCoreWebApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Repository
{
    public class Language_Repository
    {
        private BookStoreDbContext MyContext = null;
        public Language_Repository(BookStoreDbContext _Context)
        {
            MyContext = _Context;
        }

        public async Task<List<MstLanguages>> GetAllLanguages()
        {
            List<MstLanguages> MyModel = await MyContext.MstLanguages.Select(item => new MstLanguages
            {
                ID = (int)item.ID,
                vName = item.vName,
             }).ToListAsync();

            return MyModel;
        }
    }
}
