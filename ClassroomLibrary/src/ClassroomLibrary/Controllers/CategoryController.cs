using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClassroomLibrary.Models;
using ClassroomLibrary.ViewModels;
using ClassroomLibrary.Data;

namespace ClassroomLibrary.Controllers
{
    public class CategoryController : Controller
    {
        
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();

            return View(categories);
        }
        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                Category newCategory = new Category
                {
                    Name = addCategoryViewModel.NameOfCategory
                };
                context.Categories.Add(newCategory);
                context.SaveChanges();

                return Redirect("/Category/Index");
            }
            return View(addCategoryViewModel);
        }
        private readonly ClassroomLibraryDbContext context;
        public CategoryController(ClassroomLibraryDbContext dbContext)
        {
            context = dbContext;
        }
    }
}
    

