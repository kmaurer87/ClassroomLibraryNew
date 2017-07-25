using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassroomLibrary.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;



namespace ClassroomLibrary.ViewModels
{
    public class AddUserViewModel
    {
   
        [Required(ErrorMessage = "You must enter your name")]
        [Display(Name = "First and Last Name")]
        public string FullName { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter a username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must enter a password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Passwords don't match")]
        [Display(Name = "Type your password again")]
        public string VerifyPassword { get; set; }
        


       
        }
}
