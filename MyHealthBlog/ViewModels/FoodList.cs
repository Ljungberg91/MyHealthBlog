using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHealthBlog.ViewModels
{
    public class FoodList
    {
        public IEnumerable<FoodObject> ListOfFoods { get; set; }
        public IEnumerable<FoodCategory> Categorys { get; set; }
        public IEnumerable<Article> Articles { get; set; }
    }
}
