using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models.DataMappers
{
    public class UserMapper
    {
        //lista
        public static List<User> theUsers = new List<User>
        {
            new User
            {
                Id = 0,
                Name = "James",
                Password = "James"
            },

            new User
            {
                Id = 1,
                Name = "John",
                Password = "John"
            },

            new User
            {
                Id = 2,
                Name = "Jim",
                Password = "Jim"
            }
        };

        //add user
        public void addUser(User u)
        {
            theUsers.Add(u);
        }

        //check if in list
        public bool checkUserLogin(User u)
        {
            if (theUsers.Contains(u))
            {
                return true;
            }
            return false;
        }
    }
}