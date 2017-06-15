using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Data.IRepos;
using MyHealthBlog.Domain;
using MyHealthBlog.Data.Repos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyHealthBlog.Controllers
{
    public class FoodController : Controller
    {
        private readonly FoodRepo _foodRepo;

        public FoodController(/*IFoodRepo foodRepo*/)
        {
            _foodRepo = new FoodRepo();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            FoodObject food = new FoodObject();

            return View(food);
        }
        [HttpPost]
        public IActionResult Create(FoodObject food)
        {
            if(food == null)
            {
                return NotFound("Could not create object.");
            }

            _foodRepo.Create(food);
            _foodRepo.Save();

            return RedirectToAction("Index","Home");
        }
    }
}
