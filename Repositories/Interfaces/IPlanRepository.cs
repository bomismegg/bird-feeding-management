using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IPlanRepository
    {
        List<Plan> GetPlans();
        Plan GetPlanById(int planId);
        void AddPlan(Plan plan);
        void UpdatePlan(Plan plan);
        void DeletePlan(int planId);
    }
}
