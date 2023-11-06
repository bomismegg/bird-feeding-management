using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IBirdRepository
    {
        List<Bird> GetBirds();
        Bird GetBirdById(int birdId);
        void AddBird(Bird bird);
        void UpdateBird(Bird bird);
        void DeleteBird(int birdId);

        public Bird GetBirdWithFoods(int birdId);
        public void AddBirdFood(BirdFood birdFood);
    }
}
