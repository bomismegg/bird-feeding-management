using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.IRepository
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUserById(int userId);
        User GetUser(string email, string password);    
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
    }
}
