using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BirdDAO
    {
        private static BirdDAO instance = null;
        private static readonly object instanceLock = new object();
        private BirdfoodmgrContext context;

        public static BirdDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BirdDAO();
                    }
                    return instance;
                }
            }
        }

        private BirdDAO()
        {
            context = new BirdfoodmgrContext();
        }

        public List<Bird> GetBirds()
        {
            try
            {
                return context.Birds
                    .Include(b => b.BirdFoods)
                    .Include(b => b.Cage)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Bird GetBirdById(int birdId)
        {
            return context.Birds
                .Include(b => b.BirdFoods)
                .Include(b => b.Cage)
                .FirstOrDefault(b => b.Id == birdId);
        }

        public void AddBird(Bird bird)
        {
            context.Birds.Add(bird);
            context.SaveChanges();
        }

        public void UpdateBird(Bird bird)
        {
            context.Entry(bird).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteBird(int birdId)
        {
            var bird = GetBirdById(birdId);
            if (bird != null)
            {
                context.Birds.Remove(bird);
                context.SaveChanges();
            }
        }

        public Bird GetBirdWithFoods(int birdId)
        {
            return context.Birds
                .Include(b => b.BirdFoods)
                    .ThenInclude(bf => bf.Food)
                .FirstOrDefault(b => b.Id == birdId);
        }
    }
}
