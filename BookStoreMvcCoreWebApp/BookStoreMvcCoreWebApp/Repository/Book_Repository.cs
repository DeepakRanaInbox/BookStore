using BookStoreMvcCoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Repository
{
    public class Book_Repository
    {
        public List<Book_Model> GetAllBooks()
        {
            return DataSource();
        }

        public  Book_Model GetBookByID(int id)
        {
            return DataSource().Where(var => var.ID == id).FirstOrDefault();
        }

        public List<Book_Model> SearchBooks(string title,string author)
        {
            return DataSource().Where(var => var.title.Contains(title) && var.author.Contains(author)).ToList();
        }

        private List<Book_Model> DataSource()
        {
            List<Book_Model> MyData = new List<Book_Model>();

            MyData = new List<Book_Model>()
            {
                new Book_Model {ID=1,title="C#",author="Deepak Rana" },
                new Book_Model {ID=2,title="React JS",author="Arun Narwal" },
                new Book_Model {ID=3,title="AZURE",author="Deepak Rana" },
                new Book_Model {ID=4,title="ADO",author="Nitish" },
                new Book_Model {ID=5,title="Power shell",author="Harsh Jassal" },
                new Book_Model {ID=6,title=".Net Core",author="Harsh Jassal" }
            };

            return MyData;

        }

    }
}
