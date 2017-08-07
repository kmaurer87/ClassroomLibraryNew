using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using ClassroomLibrary.ViewModels;
using ClassroomLibrary.Data;
using ClassroomLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomLibrary.Controllers
{
    public class BookController : Controller
    {
        private ClassroomLibraryDbContext context;

        public BookController(ClassroomLibraryDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index(AddBookViewModel addBookViewModel)
        {
            // Book userLibrary = new Book();
            // User user = new User();

            /* var thisUserId = (from x in context.Users
                               where x.Username == loginViewModel.UserName
                               select new
                               {
                                   x.ID
                               }).FirstOrDefault();


              */
            IList<Book> yourbooks = context.Book.ToList();
           



            // IList<UserLibrary> yourbooks =
            //   context.UserLibrary.Include(c => c.OneUserID.Equals(thisUserId)).ToList();


            return View(yourbooks);
        }


        public IActionResult Add()
        {

            AddBookViewModel addUserLibraryViewModel = new AddBookViewModel();

   

            return View(addUserLibraryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddBookViewModel addUserLibraryViewModel, LoginViewModel loginViewModel)
        {

            if (ModelState.IsValid)
            {
                //   Category newCategory = context.Categories.Single(c => c.ID == addUserLibraryViewModel.CategoryID);



                //   var thisUserId = (from x in context.Users
                //  where x.Username == loginViewModel.UserName
                // select x.ID).FirstOrDefault();

                //  User thisUser = context.Users.Single(c => c.ID == thisUserId && thisUserId == addUserLibraryViewModel.UserID);
               // Book = context.Users.FirstOrDefault().ID;

                Book userLibrary = new Book
                {

                        IdOfUser = context.Users.FirstOrDefault().ID,
                        Title = addUserLibraryViewModel.BookTitle,
                        AuthorFName = addUserLibraryViewModel.AuthorFName,
                        AuthorLName = addUserLibraryViewModel.AuthorLName,
                        BookLevel = addUserLibraryViewModel.BookLevel,
                        Genre = addUserLibraryViewModel.Genre,
                       // Category = newCategory,
                        
                    };


                    context.Book.Add(userLibrary);
                    context.SaveChanges();


                    return Redirect("/Book/Index");

                    //  return Redirect("/UserLibrary/Index");
                }

            

            return View(addUserLibraryViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Books";
            ViewBag.cheeses = context.Book.ToList();
            return View();
        }

       // [HttpPost]
       // public IActionResult Remove(int[] cheeseIds)
       // {
         //   foreach (int cheeseId in cheeseIds)
          //  {
           //     Cheese theCheese = context.Cheeses.Single(c => c.ID == cheeseId);
           //     context.Cheeses.Remove(theCheese);
           // }

           // context.SaveChanges();

          //  return Redirect("/");
       // }
    }
 

        
    }

