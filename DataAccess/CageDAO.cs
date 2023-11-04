using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class CageDAO
    {
        private static List<Cage> cageList = new List<Cage>();

        private static CageDAO instance = null;
        private static readonly object instanceLock = new object();

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

        public List<Cage> GetCages()
        {
            return cageList;
        }

        public Cage GetCageById(int cageId)
        {
            foreach (Cage c in cageList)
            {
                if (c.Id == cageId)
                {
                    return c;
                }
            }
            return null;
        }

        public void AddCage(Cage cage)
        {
            Cage existCage = GetCageById(cage.Id);
            if (existCage == null)
            {
                cageList.Add(cage);
            }
            else
            {
                throw new Exception("Duplicate cage");
            }
        }

        public void UpdateCage(Cage cage)
        {
            Cage existCage = GetCageById(cage.Id);
            if (existCage != null)
            {
                cageList[cageList.IndexOf(existCage)] = cage;
            }
            else
            {
                throw new Exception("Cage not found");
            }
        }

        public void DeleteCage(int cageId)
        {
            Cage existCage = GetCageById(cageId);
            if (existCage != null)
            {
                cageList.Remove(existCage);
            }
            else
            {
                throw new Exception("Cage not found");
            }
        }
    }
}