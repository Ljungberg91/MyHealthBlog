
using MyHealthBlog.Data.IRepos;
using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace MyHealthBlog.Data.Repos
{
    public class FoodRepo : IFoodRepo
    {
        private readonly MyHealthBlogContext _context;

        public FoodRepo(/*MyHealthBlogContext context*/)
        {
            _context = new MyHealthBlogContext();
        }
        public void Create(FoodObject foodObject)
        {
            _context.FoodObjects.Add(foodObject);
        }


        public void Delete(FoodObject foodObject)
        {
            _context.FoodObjects.Remove(foodObject);
        }

        public IEnumerable<FoodObject> GetAllFoodObjects
        {
            get
            {
                return _context.FoodObjects.Include(c => c.Category);
            }
        }

        public void Update(FoodObject foodObject)
        {
            FoodObject fObject = _context.FoodObjects.FirstOrDefault(f => f.Id == foodObject.Id);
            fObject = foodObject;
        }

        public FoodObject GetFoodById(int foodId)
        {
            return _context.FoodObjects.FirstOrDefault(f => f.Id == foodId);
        }

        public void AddCategory(FoodCategory category)
        {
             category =  new FoodCategory { FoodType = Domain.Type.Berries };
            _context.FoodCategories.Add(category);
        }

        public FoodObject NameExists(string name)
        {
            FoodObject exists = _context.FoodObjects.FirstOrDefault(n => n.Name == name);
            return exists;
        }
       
        public void Save()
        {
            _context.SaveChanges();
        }

       
    }
}

