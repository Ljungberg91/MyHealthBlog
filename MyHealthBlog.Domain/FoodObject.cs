using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Domain
{
    public class FoodObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaloriesPer100g { get; set; }
        public int Fat { get; set; }
        public int Carb { get; set; }
        public int Protein { get; set; }
        public string Description { get; set; }
        public string Links { get; set; }
        public string ImageUrl { get; set; }
        public int FoodCategoryId { get; set; }
        public virtual FoodCategory Category { get; set; }
    }
}
        
 
      
