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
    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            UserDAO.Instance.AddUser(user);
        }

        public void DeleteUser(int userId)
        {
            UserDAO.Instance.DeleteUser(userId);
        }

        public User GetUserById(int userId)
        {
            return UserDAO.Instance.GetUserById(userId);
        }

        public List<User> GetUsers()
        {
            return UserDAO.Instance.GetUsers();
        }

        public void UpdateUser(User user)
        {
            UserDAO.Instance.UpdateUser(user);
        }
    }
}
