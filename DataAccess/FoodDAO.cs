using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class FoodDAO
    {
        private static FoodDAO instance = null;
        private static readonly object instanceLock = new object();
        private BirdfoodmgrContext context;

        private FoodDAO()
        {
            context = new BirdfoodmgrContext();
        }

        public static FoodDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FoodDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Food> GetFoods()
        {
            try
            {
                return context.Foods.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Food GetFoodById(int foodId)
        {
            return context.Foods.FirstOrDefault(f => f.Id == foodId);
        }

        public List<CageFood> GetCageFoodByCageId(int id)
        {
            return context.CageFoods.Where(cf => cf.Cageid == id)
                .Include(cf=> cf.Food)
                .ToList();
        }

        public void AddFood(Food food)
        {
            Food existFood = GetFoodById(food.Id);
            if (existFood == null)
            {
                context.Foods.Add(food);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Duplicate food");
            }
        }

        public void UpdateFood(Food food)
        {
            Food existFood = GetFoodById(food.Id);
            if (existFood != null)
            {
                context.Entry(existFood).CurrentValues.SetValues(food);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Food not found");
            }
        }

        public void DeleteFood(int foodId)
        {
            Food existFood = GetFoodById(foodId);
            if (existFood != null)
            {
                context.Foods.Remove(existFood);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Food not found");
            }
        }
    }
}
