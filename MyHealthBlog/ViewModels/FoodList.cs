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
        public bool Update { get; set; }
        public bool Delete { get; set; }
    }
}
