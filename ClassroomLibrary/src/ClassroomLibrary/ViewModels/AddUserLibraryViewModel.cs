using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ClassroomLibrary.Data;
using ClassroomLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;




namespace ClassroomLibrary.ViewModels
{
    public class AddUserLibraryViewModel
    {

        [Required(ErrorMessage = "You must select a category")]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "You must enter a title")]
        [Display(Name = "Title of Book")]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "You must enter the author's first name")]
        [Display(Name = "Author's First Name")]
        public string AuthorFName { get; set; }

        [Required(ErrorMessage = "You must enter the author's last name")]
        [Display(Name = "Author's Last Name")]
        public string AuthorLName { get; set; }

        [Required(ErrorMessage = "You must enter a book level")]
        [Display(Name = "Book Level")]
        public int BookLevel { get; set; }

        [Required(ErrorMessage = "You must enter a genre")]
        [Display(Name = "Genre")]
        public string Genre { get; set; }


        //public List<SelectListItem> Authors { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>();
        //public List<SelectListItem> Titles { get; set; } = new List<SelectListItem>();

        public AddUserLibraryViewModel() { }
        public AddUserLibraryViewModel(IEnumerable<Category> categories)
        {

            Categories = new List<SelectListItem>();
            foreach (var category in categories)
            {
                Categories.Add(new SelectListItem
                {
                    Value = (category.ID).ToString(),
                    Text = category.Name
                });
            }


        }
    }
}
    



           


// Categories.Add(new SelectListItem
// {
//  Value = (category.ID).ToString(),
//Text = category.Name
//});
//}


// }




