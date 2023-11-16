using System.Collections.Generic;
using BusinessObject.Models;

namespace DataAccess
{
    public class UserDAO
    {
        private static List<User> userList = new List<User>();

        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        private BirdfoodmgrContext context;
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                    return instance;
                }
            }
        }

        private UserDAO()
        {
            context = new BirdfoodmgrContext();
        }
        public List<User> GetUsers()
        {
            return userList;
        }

        public User GetUser(string  email, string password)
        {
            foreach (User user in context.Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public User GetUserById(int userId)
        {
            foreach (User u in userList)
            {
                if (u.Id == userId)
                {
                    return u;
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            User existUser = GetUserById(user.Id);
            if (existUser == null)
            {
                userList.Add(user);
            }
            else
            {
                throw new Exception("Duplicate user");
            }
        }

        public void UpdateUser(User user)
        {
            User existUser = GetUserById(user.Id);
            if (existUser != null)
            {
                userList[userList.IndexOf(existUser)] = user;
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public void DeleteUser(int userId)
        {
            User existUser = GetUserById(userId);
            if (existUser != null)
            {
                userList.Remove(existUser);
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}