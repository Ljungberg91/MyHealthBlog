using Microsoft.EntityFrameworkCore;
using MyHealthBlog.Domain;

namespace MyHealthBlog.Data
{
    public class MyHealthBlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<FoodObject> FoodObjects { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = HealthBlogDb; Trusted_Connection = True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ArticleRecipe>().HasKey(k => new { k.RecipeId, k.ArticleId });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
