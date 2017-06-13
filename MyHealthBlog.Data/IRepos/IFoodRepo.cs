﻿using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Data.IRepos
{
    public interface IFoodRepo
    {
        IEnumerable<FoodObject> GetAllFoodObjects { get; }
        FoodObject GetFoodById(int foodId);
        void Add(FoodObject foodObject);
        void Update(FoodObject foodObject);
        void Delete(FoodObject foodObject);
        void Save();
    }
}
