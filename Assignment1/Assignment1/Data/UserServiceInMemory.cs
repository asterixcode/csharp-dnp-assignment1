using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assignment1.Data
{
    public class UserServiceInMemory : IUserService
    {
        private List<User> users;

        public UserServiceInMemory()
        {
            users = new[]
            {
                new User()
                {
                    UserName = "admin",
                    Password = "admin",
                    Role = "ADMIN"
                },
                new User()
                {
                    UserName = "lucas",
                    Password = "12345",
                    Role = "STUDENT",
                }
            }.ToList();
        }
        
        public User ValidateUser(string UserName, string Password)
        {
            User temp = users.FirstOrDefault(user => user.UserName.Equals(UserName));
            if (temp == null)
            {
                throw new Exception("User not found.");
            }

            if (!temp.Password.Equals(Password))
            {
                throw new Exception("Incorrect password.");
            }

            return temp;
        }
    }
}