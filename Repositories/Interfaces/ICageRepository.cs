using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface ICageRepository
    {
        List<Cage> GetCages();
        Cage GetCageById(int cageId);
        void AddCage(Cage cage);
        void UpdateCage(Cage cage);
        void DeleteCage(int cageId);
    }
}
