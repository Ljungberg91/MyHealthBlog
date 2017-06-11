using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Domain
{
   public class FoodCategory
    {
        public FoodCategory()
        {
            Recipes = new List<Recipe>();
            FoodObjects = new List<FoodObject>();
            Articles = new List<Article>();
        }
        public int Id { get; set; }
        public Type FoodType { get; set; }
        public string ImgUrl { get; set; }
        public List<Recipe> Recipes { get; set; }
        public List<FoodObject> FoodObjects { get; set; }
        public List<Article> Articles { get; set; }
    }
    public enum Type
    {
        Vegetables,
        Meats,
        Fruits,
        Grains,
        Berries,
        Fish,
    }
}
