using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Domain;
using MyHealthBlog.Data.Repos;

namespace MyHealthBlog.Controllers
{
    public class CategoryController : Controller
    {

        private readonly GenericRepo<FoodCategory> _genericRepo;

        [HttpGet]
        public IActionResult Create()
        {
            FoodObject food = new FoodObject();

            return View(food);
        }
        [HttpPost]
        public IActionResult Create(FoodCategory category)
        {
            _genericRepo.Add(category);
            _genericRepo._Context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
