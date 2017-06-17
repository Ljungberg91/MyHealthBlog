using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Domain;
using MyHealthBlog.Data.Repos;
using MyHealthBlog.ViewModels;

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
            
            _foodRepo.NameExists(food.Name);

            if (food == null)
            {
                return NotFound("Could not create object.");
            }

            _foodRepo.Create(food);
            _foodRepo.Save();

            return RedirectToAction("Index", "Home");
        }
        
        public IActionResult Delete()
        {
            FoodList foodlist = new FoodList();
            foodlist.ListOfFoods = _foodRepo.GetAllFoodObjects;
            foodlist.Delete = true;
            return View(foodlist);
        }
        
        public IActionResult Delete1(int id)
        {
            FoodObject food = _foodRepo.GetFoodById(id);

            if (food == null)
            {
                return NotFound("Something went wrong");
            }
            _foodRepo.Delete(food);
            _foodRepo.Save();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update()
        {
            FoodList foodlist = new FoodList();
            foodlist.ListOfFoods = _foodRepo.GetAllFoodObjects;
            foodlist.Update = true;
            return View(foodlist);
        }
    }
}
            
