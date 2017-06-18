using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Domain;
using MyHealthBlog.ViewModels;
using MyHealthBlog.Data.Repos;

namespace MyHealthBlog.Controllers
{
    public class CategoryController : Controller
    {

        //private readonly GenericRepo<FoodCategory> _genericRepo;
        private readonly CategoryRepo _categoryRepo;
        public CategoryController()
        {
            _categoryRepo = new CategoryRepo();
            //_genericRepo = new GenericRepo<FoodCategory>();
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
            _categoryRepo.Create(category);
            _categoryRepo.Save();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete()
        {
            FoodList foodlist = new FoodList();
            foodlist.Categorys = _categoryRepo.GetAllCategorys;

            return View(foodlist);
        }

        public IActionResult Delete1(int id)
        {
            FoodCategory category = _categoryRepo.GetCategoryById(id);

            if (category == null)
            {
                return NotFound("Something went wrong");
            }
            _categoryRepo.Delete(category);
            _categoryRepo.Save();

            return RedirectToAction("Index", "Home");
        }
    }
}
