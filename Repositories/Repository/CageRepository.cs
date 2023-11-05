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
    public class CageRepository : ICageRepository
    {
        public void AddCage(Cage cage)
        {
            CageDAO.Instance.AddCage(cage);
        }

        public void DeleteCage(int cageId)
        {
            CageDAO.Instance.DeleteCage(cageId);
        }

        public Cage GetCageById(int cageId)
        {
            return CageDAO.Instance.GetCageById(cageId);
        }

        public List<Cage> GetCages()
        {
            return CageDAO.Instance.GetCages();
        }

        public void UpdateCage(Cage cage)
        {
            CageDAO.Instance.UpdateCage(cage);
        }
    }
}
