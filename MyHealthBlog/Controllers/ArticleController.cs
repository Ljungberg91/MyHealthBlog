using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.Data.Repos;
using MyHealthBlog.Domain;
using MyHealthBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHealthBlog.Controllers
{
    public class ArticleController : Controller
    {
        //private readonly GenericRepo<FoodCategory> _genericRepo;
        private readonly ArticleRepo _articleRepo;
        public ArticleController()
        {
            _articleRepo = new ArticleRepo();
            //_genericRepo = new GenericRepo<FoodCategory>();
        }
        [HttpGet]
        public IActionResult Create()
        {
           Article article = new Article();

            return View(article);
        }
        [HttpPost]
        public IActionResult Create(Article article)
        {
            if (article == null)
            {
                return NotFound("Could not create object.");
            }
            _articleRepo.Create(article);
            _articleRepo.Save();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete()
        {
            FoodList foodlist = new FoodList();
            foodlist.Articles = _articleRepo.GetAllArticles;

            return View(foodlist);
        }

        public IActionResult Delete1(int id)
        {
            Article article = _articleRepo.GetArticleById(id);

            if (article == null)
            {
                return NotFound("Something went wrong");
            }
            _articleRepo.Delete(article);
            _articleRepo.Save();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Update()
        {
            FoodList foodlist = new FoodList();
            foodlist.Articles = _articleRepo.GetAllArticles;
            return View(foodlist);
        }
        [HttpGet]
        public IActionResult UpdateForm(int id)
        {
            Article article = _articleRepo.GetArticleById(id);
            return View(article);
        }
        [HttpPost]
        public IActionResult UpdateForm(Article article)
        {
            if (article == null)
            {
                return NotFound("Something went wrong");
            }
            _articleRepo.Update(article);
            _articleRepo.Save();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult GetDetails()
        {
            return View();
        }


        public IActionResult Details(Article article)
        {
            Article article1 = _articleRepo.NameExists(article.Content);
            if (article1 == null)
            {
                return NotFound("Something went wrong");
            }

            return View(article1);
        }
    }
}
