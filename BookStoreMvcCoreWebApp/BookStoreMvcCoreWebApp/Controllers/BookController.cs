using BookStoreMvcCoreWebApp.Models;
using BookStoreMvcCoreWebApp.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Controllers
{
    public class BookController : Controller
    {

        private readonly Book_Repository MyBook_Repository;

        public BookController()
        {
            MyBook_Repository = new Book_Repository();
        }
        public IActionResult Index()
        {
            return View(MyBook_Repository.GetAllBooks());
        }

        [Route("Book-Details/{id}",Name ="BookDetail")]
        public IActionResult GetBookDetails(int id)
        {
            return View(MyBook_Repository.GetBookByID(id));
        }

        public IActionResult SearchBooks(string title,string author)
        {
            return View(MyBook_Repository.SearchBooks(title,author));
        }

        public IActionResult AddBook()
        {
            Book_Model MyModel = new Book_Model();

            return View(MyModel);
        }

        [HttpPost]
        public IActionResult AddBook(Book_Model MyModel)
        {
            return RedirectToAction("Index");
        }
    }
}
