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
                new Book_Model {ID=1,title="C#",author="Deepak Rana",discription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",imagePath="https://cdn.elearningindustry.com/wp-content/uploads/2016/05/top-10-books-every-college-student-read-1024x640.jpeg",category="Programing",totalPages="1102",language="English"  },
                new Book_Model {ID=2,title="React JS",author="Arun Narwal" ,discription="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. ",imagePath="https://cdn.elearningindustry.com/wp-content/uploads/2016/05/top-10-books-every-college-student-read-1024x640.jpeg",category="Client Script",totalPages="902",language="English" },
                new Book_Model {ID=3,title="AZURE",author="Deepak Rana" ,discription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",imagePath="https://cdn.elearningindustry.com/wp-content/uploads/2016/05/top-10-books-every-college-student-read-1024x640.jpeg",category="Cloud",totalPages="1602",language="English" },
                new Book_Model {ID=4,title="ADO",author="Nitish",discription="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. ",imagePath="https://cdn.elearningindustry.com/wp-content/uploads/2016/05/top-10-books-every-college-student-read-1024x640.jpeg",category="Programing",totalPages="102",language="English"  },
                new Book_Model {ID=5,title="Power shell",author="Harsh Jassal" ,discription="Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",imagePath="https://cdn.elearningindustry.com/wp-content/uploads/2016/05/top-10-books-every-college-student-read-1024x640.jpeg",category="IT",totalPages="1802",language="English" },
                new Book_Model {ID=6,title=".Net Core",author="Harsh Jassal",discription="There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. ",imagePath="https://cdn.elearningindustry.com/wp-content/uploads/2016/05/top-10-books-every-college-student-read-1024x640.jpeg",category="Web Development",totalPages="1402",language="English" },
            };

            return MyData;

        }

    }
}
