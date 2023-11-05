using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IFoodRepository
    {
        List<Food> GetFoods();
        Food GetFoodById(int foodId);
        void AddFood(Food food);
        void UpdateFood(Food food);
        void DeleteFood(int foodId);

    }
}
