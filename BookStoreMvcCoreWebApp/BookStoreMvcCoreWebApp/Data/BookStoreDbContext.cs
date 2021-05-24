using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Data
{
    public class BookStoreDbContext : DbContext 
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) :base(options)
        {

        }

        public DbSet<TbBooks> TbBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionBuilder)
        {
            OptionBuilder.UseSqlServer("server=DESKTOP-G2A16VT\\SQLEXPRESS;database=BookStoreDB;Integrated Security=True;");
            base.OnConfiguring(OptionBuilder);
        }
    }
}
