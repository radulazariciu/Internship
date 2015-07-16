using Nike.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike.DataLayer.Mappers
{
    public class UserMapper
    {
        //lista
        public List<User> theUsers = new List<User>
        {
            new User
            {
               Id = 0,
               FirstName = "Jim",
               LastName = "Jones",
               Gender = "male",
               ScreenName = "JimJ",
               Password = "JimJones",
               emailAddress = "jimjones@gmail.com",
               Zipcode = 12345,
               DateOfBirth = DateTime.Today
            },

            new User
            {
               Id = 1,
               FirstName = "Jim2",
               LastName = "Jones2",
               Gender = "male",
               ScreenName = "JimJ2",
               Password = "JimJones2",
               emailAddress = "jimjones2@gmail.com",
               Zipcode = 12345,
               DateOfBirth = DateTime.Today
            },

            new User
            {
                Id = 2,
               FirstName = "Jim3",
               LastName = "Jones3",
               Gender = "male",
               ScreenName = "JimJ3",
               Password = "JimJones3",
               emailAddress = "jimjones3@gmail.com",
               Zipcode = 12345,
               DateOfBirth = DateTime.Today
            }
        };

        //add user
        public void addUser(User u)
        {
            theUsers.Add(u);
        }


        public Boolean checkUserExists(User u)
        {
           // var user = theUsers.FirstOrDefault(usr => usr.emailAddress == u.emailAddress);
            foreach (var item in theUsers)
            {
                if(item.emailAddress == u.emailAddress)
                {
                    return true;
                }
            }
            //if (user != null)
            //{
            //        return true;
            //}
            return false;
        }

        ////login check
        //public bool checkUserLogin(User u)
        //{
        //    var user = theUsers.FirstOrDefault(usr => usr.emailAddress == u.emailAddress);
        //    if (user.Password == u.Password)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //get user list
        public List<User> GetAllUsers()
        {
            return theUsers;
        }
    }
    
}
