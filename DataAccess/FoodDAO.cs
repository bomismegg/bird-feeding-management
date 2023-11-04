using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class FoodDAO
    {
        private static List<Food> foodList = new List<Food>();

        private static FoodDAO instance = null;
        private static readonly object instanceLock = new object();

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
            return foodList;
        }

        public Food GetFoodById(int foodId)
        {
            foreach (Food f in foodList)
            {
                if (f.Id == foodId)
                {
                    return f;
                }
            }
            return null;
        }

        public void AddFood(Food food)
        {
            Food existFood = GetFoodById(food.Id);
            if (existFood == null)
            {
                foodList.Add(food);
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
                foodList[foodList.IndexOf(existFood)] = food;
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
                foodList.Remove(existFood);
            }
            else
            {
                throw new Exception("Food not found");
            }
        }
    }
}