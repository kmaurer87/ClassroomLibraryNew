
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassroomLibrary.Data;
using ClassroomLibrary.ViewModels;
using ClassroomLibrary.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;


namespace ClassroomLibrary.Controllers
{

    public class LibraryController : Controller
    {
        private ClassroomLibraryDbContext context;

        public LibraryController(ClassroomLibraryDbContext dbContext)
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

                var thisuser = (from userlist in context.Users
                                where userlist.Username == loginViewModel.UserName && userlist.Password == loginViewModel.Password
                                select new
                                {
                                    userlist.ID,
                                    userlist.Username
                                }).ToList();
                if (thisuser.FirstOrDefault() != null)

                {

                    return Redirect("/Library/Welcome");
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

                return Redirect("/Library");
            }

            return View(addUserViewModel);
        }

    }


       

       
    }
    


