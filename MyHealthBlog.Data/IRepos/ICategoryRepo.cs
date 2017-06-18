using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Data.IRepos
{
    public interface ICategoryRepo
    {
        IEnumerable<FoodCategory> GetAllFoodObjects { get; }
        FoodObject GetFoodById(int foodId);
        void Create(FoodCategory category);
        void Update(FoodCategory category);
        void Delete(FoodCategory category);
        void Save();
    }
}
