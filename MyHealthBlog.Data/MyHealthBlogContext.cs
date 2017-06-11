using Microsoft.EntityFrameworkCore;
using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Data
{
    public class MyHealthBlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<FoodObject> FoodObjects { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }
}
