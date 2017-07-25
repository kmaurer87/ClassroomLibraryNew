using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassroomLibrary.Models;
using System.ComponentModel.DataAnnotations;

namespace ClassroomLibrary.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Category")]
        public string NameOfCategory { get; set; }
    }
}
