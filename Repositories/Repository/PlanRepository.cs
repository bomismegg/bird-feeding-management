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
    public class PlanRepository : IPlanRepository
    {
        public void AddPlan(Plan plan)
        {
            PlanDAO.Instance.AddPlan(plan);
        }

        public void DeletePlan(int planId)
        {
            PlanDAO.Instance.DeletePlan(planId);
        }

        public Plan GetPlanById(int planId)
        {
         return PlanDAO.Instance.GetPlanById(planId);
        }

        public List<Plan> GetPlans()
        {
            return PlanDAO.Instance.GetPlans();
        }

        public void UpdatePlan(Plan plan)
        {
            PlanDAO.Instance.UpdatePlan(plan);
        }
    }
}
