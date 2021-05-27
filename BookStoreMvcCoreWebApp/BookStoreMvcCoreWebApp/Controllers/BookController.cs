using BookStoreMvcCoreWebApp.Models;
using BookStoreMvcCoreWebApp.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Controllers
{
    public class BookController : Controller
    {

        private readonly Book_Repository MyBook_Repository;
        private readonly Language_Repository MyLanguage_Repository;
        private readonly IWebHostEnvironment myIWebHostEnvironment;

        
        public BookController(Book_Repository _Book_Repository,  Language_Repository _language_repository, IWebHostEnvironment _IWebHostEnvironment)
        {
            MyBook_Repository = _Book_Repository;
            MyLanguage_Repository = _language_repository;
            myIWebHostEnvironment = _IWebHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            return View(await MyBook_Repository.GetAllBooks());
        }

        [Route("Book-Details/{id}",Name ="BookDetail")]
        public async Task<IActionResult> GetBookDetails(int id)
        {
            return View( await MyBook_Repository.GetBookByID(id));
        }

        public IActionResult SearchBooks(string title,string author)
        {
            return View(MyBook_Repository.SearchBooks(title,author));
        }

        public async Task<IActionResult> AddBook()
        {
            Book_Model MyModel = new Book_Model();

            ViewBag.MyLanguageList = new SelectList(await MyLanguage_Repository.GetAllLanguages(), "ID","vName");
            

            //var Group1 = new SelectListGroup() {Name="India" };
            //var Group2 = new SelectListGroup() { Name = "Chaina",Disabled=true };

            //ViewBag.MyLanguageList = new List<SelectListItem>(){
            //new SelectListItem { Value = "1" , Text = "Hindi", Group = Group1 },
            //new SelectListItem { Value = "1" , Text = "Punjabi", Group = Group1 },
            //new SelectListItem { Value = "1" , Text = "Odia", Group = Group1 },
            //new SelectListItem { Value = "1" , Text = "Chainies", Group = Group2 }
            //};


            return View(MyModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(Book_Model MyModel)
        {

            if(MyModel.CoverPhoto !=null )
            {
                string folder  = "BlobStorage/Book/Cover/";
                folder +=   Guid.NewGuid().ToString().Substring(1,10)+ "_" +MyModel.CoverPhoto.FileName;
                string serverfolder  = Path.Combine(myIWebHostEnvironment.WebRootPath,folder);

                MyModel.imagePath = "/" + folder;

               await MyModel.CoverPhoto.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
            }

            if (MyModel.galleryimages != null)
            {
                MyModel.Gallery = new List<GalleryImagesModel>();
                foreach (IFormFile imageItem in MyModel.galleryimages)
                {

                    MyModel.Gallery.Add(new GalleryImagesModel { 
                    Name= imageItem.FileName,
                    Url= await UploadImages("BlobStorage/Book/Gallery/", imageItem),
                    });
                     
                }
  
            }
            if (MyModel.bookpdffile != null)
            {
                string folder = "BlobStorage/Book/PDF/";
                folder += Guid.NewGuid().ToString().Substring(1, 10) + "_" + MyModel.bookpdffile.FileName;
                string serverfolder = Path.Combine(myIWebHostEnvironment.WebRootPath, folder);

                MyModel.bookpdfurl = "/" + folder;

                await MyModel.CoverPhoto.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
            }


            int BookID = 0;

            if (ModelState.IsValid)
            {
                BookID = await MyBook_Repository.CreatedEntity(MyModel);
            }
            else
            {
                ModelState.AddModelError("", "This is model error from action!");
            }

            if (BookID>0)
                return RedirectToAction("Index");
            else
                return View("AddBook", MyModel);
        }

        private async Task<string> UploadImages(string folder,IFormFile myIFormFile)
        {
            if (myIFormFile != null)
            {
                folder += Guid.NewGuid().ToString().Substring(1, 10) + "_" + myIFormFile.FileName;

                string serverfolder = Path.Combine(myIWebHostEnvironment.WebRootPath, folder);
                 
                await myIFormFile.CopyToAsync(new FileStream(serverfolder, FileMode.Create));
            }

            return "/" + folder;
        }
    }
}
