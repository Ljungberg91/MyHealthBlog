using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Data.IRepos
{
    public interface IFoodRepo
    {
        IEnumerable<FoodObject> GetAllFoodObjects { get; }
        FoodObject GetFoodById(int foodId);
        void Create(FoodObject foodObject);
        void Update(FoodObject foodObject);
        void Delete(FoodObject foodObject);
        void Save();
        void AddCategory(FoodCategory category);
    }
}
