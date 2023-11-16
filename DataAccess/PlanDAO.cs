using System.Collections.Generic;
using System.Diagnostics.Contracts;
using BusinessObject.Models;

namespace DataAccess
{
    public class PlanDAO
    {
        private static List<Plan> planList = new List<Plan>();

        private static PlanDAO instance = null;
        private static readonly object instanceLock = new object();
        private BirdfoodmgrContext context;

        public static PlanDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PlanDAO();
                    }
                    return instance;
                }
            }
        }

        private PlanDAO()
        {
            context = new BirdfoodmgrContext();
        }

        public List<Plan> GetPlans()
        {
            return context.Plans.ToList();
        }

        public Plan GetPlanById(int planId)
        {
            foreach (Plan p in planList)
            {
                if (p.Id == planId)
                {
                    return p;
                }
            }
            return null;
        }

        public void AddPlan(Plan plan)
        {
            Plan existPlan = GetPlanById(plan.Id);
            if (existPlan == null)
            {
                planList.Add(plan);
            }
            else
            {
                throw new Exception("Duplicate plan");
            }
        }

        public void UpdatePlan(Plan plan)
        {
            Plan existPlan = GetPlanById(plan.Id);
            if (existPlan != null)
            {
                planList[planList.IndexOf(existPlan)] = plan;
            }
            else
            {
                throw new Exception("Plan not found");
            }
        }

        public void DeletePlan(int planId)
        {
            Plan existPlan = GetPlanById(planId);
            if (existPlan != null)
            {
                planList.Remove(existPlan);
            }
            else
            {
                throw new Exception("Plan not found");
            }
        }
    }
}