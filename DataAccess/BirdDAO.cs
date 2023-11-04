using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class BirdDAO
    {
        private static List<Bird> birdList = new List<Bird>();

        private static BirdDAO instance = null;
        private static readonly object instanceLock = new object();

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

        public List<Bird> GetBirds()
        {
            return birdList;
        }

        public Bird GetBirdById(int birdId)
        {
            foreach (Bird b in birdList)
            {
                if (b.Id == birdId)
                {
                    return b;
                }
            }
            return null;
        }

        public void AddBird(Bird bird)
        {
            Bird existBird = GetBirdById(bird.Id);
            if (existBird == null)
            {
                birdList.Add(bird);
            }
            else
            {
                throw new Exception("Duplicate bird");
            }
        }

        public void UpdateBird(Bird bird)
        {
            Bird existBird = GetBirdById(bird.Id);
            if (existBird != null)
            {
                birdList[birdList.IndexOf(existBird)] = bird;
            }
            else
            {
                throw new Exception("Bird not found");
            }
        }

        public void DeleteBird(int birdId)
        {
            Bird existBird = GetBirdById(birdId);
            if (existBird != null)
            {
                birdList.Remove(existBird);
            }
            else
            {
                throw new Exception("Bird not found");
            }
        }
    }
}