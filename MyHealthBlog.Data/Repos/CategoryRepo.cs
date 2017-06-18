using MyHealthBlog.Data.IRepos;
using System;
using System.Collections.Generic;
using MyHealthBlog.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MyHealthBlog.Data.Repos
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly MyHealthBlogContext _context;

        public CategoryRepo()
        {
            _context = new MyHealthBlogContext();
        }

        public IEnumerable<FoodCategory> GetAllCategorys
        {
            get
            {
                return _context.FoodCategories;
            }
        }

        public void Create(FoodCategory category)
        {
            _context.FoodCategories.Add(category);
        }

        public void Delete(FoodCategory category)
        {
            _context.FoodCategories.Remove(category);
        }

        public void Update(FoodCategory category)
        {
            _context.Entry(category).State = EntityState.Modified;
        }

        public void Save()
        {

            _context.SaveChanges();
        }

        public FoodCategory GetCategoryById(int foodId)
        {
            return _context.FoodCategories.FirstOrDefault(c => c.Id == foodId);
        }
    }
}

