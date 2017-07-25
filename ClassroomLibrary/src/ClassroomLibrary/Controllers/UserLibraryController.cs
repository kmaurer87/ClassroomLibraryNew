using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassroomLibrary.ViewModels;
using ClassroomLibrary.Data;
using ClassroomLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomLibrary.Controllers
{
    public class UserLibraryController : Controller
    {
        private ClassroomLibraryDbContext context;

        public UserLibraryController(ClassroomLibraryDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            IList<UserLibrary> yourbooks = context.UserLibrary.Include(c => c.Category).ToList();

            return View(yourbooks);
        }

        public IActionResult Add()
        {

            AddUserLibraryViewModel addUserLibraryViewModel = new AddUserLibraryViewModel(context.Categories.ToList());


            return View(addUserLibraryViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserLibraryViewModel addUserLibraryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category newCategory = context.Categories.Single(c => c.ID == addUserLibraryViewModel.CategoryID);

                UserLibrary yourLibrary = new UserLibrary
                {
                    Title = addUserLibraryViewModel.BookTitle,
                    AuthorFName = addUserLibraryViewModel.AuthorFName,
                    AuthorLName = addUserLibraryViewModel.AuthorLName,
                    BookLevel = addUserLibraryViewModel.BookLevel,
                    Genre = addUserLibraryViewModel.Genre,
                    Category = newCategory


                };

                context.UserLibrary.Add(yourLibrary);
                context.SaveChanges();

                return Redirect("/UserLibrary/Index");
            }
            

            return View(addUserLibraryViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Books";
            ViewBag.cheeses = context.UserLibrary.ToList();
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

