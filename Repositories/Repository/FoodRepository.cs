using BusinessObject.Models;
using DataAccess;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class FoodRepository : IFoodRepository
    {
        public void AddFood(Food food)
        {
            FoodDAO.Instance.AddFood(food);
        }

        public void DeleteFood(int foodId)
        {
            FoodDAO.Instance.DeleteFood(foodId);
        }

        public List<CageFood> GetCageFoodByCageId(int id)
        {
            return FoodDAO.Instance.GetCageFoodByCageId(id);
        }

        public Food GetFoodById(int foodId)
        {
            return FoodDAO.Instance.GetFoodById(foodId);
        }

        public List<Food> GetFoods()
        {
            return FoodDAO.Instance.GetFoods();
        }

        public void UpdateFood(Food food)
        {
            FoodDAO.Instance.UpdateFood(food);
        }
    }
}
