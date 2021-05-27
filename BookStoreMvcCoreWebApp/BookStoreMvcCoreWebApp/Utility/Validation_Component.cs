using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreMvcCoreWebApp.Utility
{
    public class MyCustomValidation:ValidationAttribute
    {
        public string Text { get; set; }
        protected override ValidationResult IsValid(object value,ValidationContext _validationContext)
        {
            if(value != null)
            {
                string bookName = value.ToString();

                //if(bookName.Contains("mvc"))

                if (bookName.Contains(this.Text))
                {
                    return ValidationResult.Success;
                }
           
            }

            return new ValidationResult(ErrorMessage ?? "Value is empty");
        }
    }
}
