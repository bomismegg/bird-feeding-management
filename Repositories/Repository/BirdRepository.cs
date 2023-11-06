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
    public class BirdRepository : IBirdRepository
    {
        public void AddBird(Bird bird)
        {
            BirdDAO.Instance.AddBird(bird);
        }

        public void DeleteBird(int birdId)
        {
            BirdDAO.Instance.DeleteBird(birdId);
        }

        public Bird GetBirdById(int birdId)
        {
            return BirdDAO.Instance.GetBirdById(birdId);
        }

        public List<Bird> GetBirds()
        {
            return BirdDAO.Instance.GetBirds();
        }

        public void UpdateBird(Bird bird)
        {
            BirdDAO.Instance.UpdateBird(bird);
        }

        public Bird GetBirdWithFoods(int birdId)
        {
            return BirdDAO.Instance.GetBirdWithFoods(birdId);
        }
        public void AddBirdFood(BirdFood birdFood)
        {
            BirdDAO.Instance.AddBirdFood(birdFood);
        }
    }
}
