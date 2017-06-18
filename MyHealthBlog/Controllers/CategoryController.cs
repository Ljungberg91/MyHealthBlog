using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Domain;
using MyHealthBlog.Data.Repos;

namespace MyHealthBlog.Controllers
{
    public class CategoryController : Controller
    {

        private readonly GenericRepo<FoodCategory> _genericRepo;
        public CategoryController()
        {
            _genericRepo = new GenericRepo<FoodCategory>();
        }
        [HttpGet]
        public IActionResult Create()
        {
            FoodCategory category = new FoodCategory();

            return View(category);
        }
        [HttpPost]
        public IActionResult Create(FoodCategory category)
        {
            if (category == null)
            {
                return NotFound("Could not create object.");
            }
            _genericRepo.Add(category);
            _genericRepo._Context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete()
        {
            FoodList foodlist = new FoodList();
            foodlist.ListOfFoods = _foodRepo.GetAllFoodObjects;

            return View(foodlist);
        }

        public IActionResult Delete1(int id)
        {
            FoodCategory category = _foodRepo.GetFoodById(id);

            if (category == null)
            {
                return NotFound("Something went wrong");
            }
            _foodRepo.Delete(category);
            _foodRepo.Save();

            return RedirectToAction("Index", "Home");
        }
    }
}
