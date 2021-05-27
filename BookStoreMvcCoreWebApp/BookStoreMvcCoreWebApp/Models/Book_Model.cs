using BookStoreMvcCoreWebApp.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Models
{
    public class Book_Model
    {
        public int ID { get; set; }

        //[Required(ErrorMessage = "Title is Required!")]
        [MyCustomValidation(ErrorMessage ="Invalid book title!",Text ="mvc")]
        public string title { get; set; }

        [Required(ErrorMessage = "Author is Required!")]
        public string author { get; set; }

        public string discription { get; set; }
        public string imagePath { get; set; }

        public string category { get; set; }

        [Required(ErrorMessage = "Total-Pages is Required!")]
        [Display( Name ="Total-Pages")]
        public string totalPages { get; set; }

     
        public string language { get; set; }


        [Required(ErrorMessage = "Language is Required!")]
        [Display(Name = "Language")]
        public int LanguageID { get; set; }
        public SelectList LanguageList { get; set; }


        [Required(ErrorMessage = "Please select image!")]
        [Display(Name = "Please upload image")]
        public IFormFile  CoverPhoto { get; set; }



        [Required(ErrorMessage = "Please select gallery images!")]
        [Display(Name = "Please upload gallery images")]
        public List<IFormFile> galleryimages { get; set; }

        public List<GalleryImagesModel> Gallery { get; set; }

        [Required(ErrorMessage = "Please select pdf!")]
        [Display(Name = "Please upload pdf file")]
        public IFormFile bookpdffile { get; set; }


        public string bookpdfurl { get; set; }

        public List<Book_Model> similerBooks { get; set; }
    }
}
