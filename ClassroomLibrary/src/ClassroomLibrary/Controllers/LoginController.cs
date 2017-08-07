
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassroomLibrary.Data;
using ClassroomLibrary.ViewModels;
using ClassroomLibrary.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace ClassroomLibrary.Controllers
{

    public class LoginController : Controller
    {
        private ClassroomLibraryDbContext context;

        public LoginController(ClassroomLibraryDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            return View(loginViewModel);
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {

                var thisuser = (from x in context.Users
                                where x.Username == loginViewModel.UserName && x.Password == loginViewModel.Password
                                select new
                                {
                                    x.ID,
                                    x.Username,
                                 
                                }).ToList();
                if (thisuser.FirstOrDefault() != null)

                {
                   
                  return Redirect("/Login/Welcome");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials");
                }
             }
            return View(loginViewModel);
        }

        public IActionResult Welcome()
        {


           

           return View();
        }
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();


            return View(addUserViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    FullName = addUserViewModel.FullName,
                    Email = addUserViewModel.Email,
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password

                };


                context.Users.Add(newUser);
                context.SaveChanges();

                return Redirect("/Login/Index");
            }

            return View(addUserViewModel);
        }

    }


       

       
    }
    


