using Microsoft.AspNetCore.Mvc;
using MyHealthBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHealthBlog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult RouteToCrud(CrudRoute CrudObejct)
        {
            return RedirectToAction(CrudObejct.Action, CrudObejct.Controller);
        }
    }
}
