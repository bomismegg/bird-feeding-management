using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class CageDAO
    {
        private static CageDAO instance = null;
        private static readonly object instanceLock = new object();
        private BirdfoodmgrContext context;

        public static CageDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CageDAO();
                    }
                    return instance;
                }
            }
        }

        private CageDAO()
        {
            context = new BirdfoodmgrContext();
        }

        public List<Cage> GetCages()
        {
            try
            {
                return context.Cages
                    .Include(cage=>cage.Birds)
                    .Include(cage=>cage.CageFoods)
                    .Include(cage=>cage.Images)
                    .Include(cage=>cage.Plans)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Cage GetCageById(int cageId)
        {
            return context.Cages
                .Include(cage => cage.Birds)
                .FirstOrDefault(c => c.Id == cageId);
        }

        public void AddCage(Cage cage)
        {
            context.Cages.Add(cage);
            context.SaveChanges();
        }

        public void UpdateCage(Cage cage)
        {
            context.Cages.Update(cage); 
            context.SaveChanges();
        }

        public void DeleteCage(int cageId)
        {
            var cage = GetCageById(cageId);
            if (cage != null)
            {
                context.Cages.Remove(cage);
                context.SaveChanges();
            }
        }
    }
}
