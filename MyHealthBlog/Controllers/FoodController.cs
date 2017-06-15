using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Data.IRepos;
using MyHealthBlog.Domain;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyHealthBlog.Controllers
{
    public class FoodController : Controller
    {
        //private readonly IFoodRepo _foodRepo;

        //public FoodController(IFoodRepo foodRepo)
        //{
        //    _foodRepo = foodRepo;
        //}

         
        public IActionResult Index()
        {
            return View();
        }

        //public ViewResult Categories()
        //{
        //    _foodRepo.AddCategory(category);

        //    return View(category);
        //}
    }
}
