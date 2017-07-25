using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ClassroomLibrary.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassroomLibrary.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
    
 }

