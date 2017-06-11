using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Domain
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string MakingDescription { get; set; }
        public string Notes { get; set; }
        public string ImgUrl { get; set; }
        public int FoodCategoryId { get; set; }
        public List<ArticleRecipe> ArticleRecipes { get; set; }
    }
}
