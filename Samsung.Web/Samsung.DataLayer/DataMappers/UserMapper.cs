using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;

namespace Samsung.DataLayer.DataMappers
{
    public class UserMapper
    {
   
        public List<User> usersList = new List<User>
        {
            new User
            {
               Id = 0,
               FirstName = "TestFM",
               LastName = "TestSN",
               Password = "test",
               EmailAddress = "test@test.com",
               Zipcode = 12345,
               DateOfBirth = DateTime.Today
            }
        };

        public void AddUser(User user)
        {
            usersList.Add(user);
        }

        public Boolean CheckUserExistence(User user)
        {
            foreach (var item in usersList)
            {
                if (item.EmailAddress.Equals(user.EmailAddress))
                {
                    return true;
                }
            }
            return false;
        }

        public List<User> GetAllUsers()
        {
            return usersList;
        }
    }
}