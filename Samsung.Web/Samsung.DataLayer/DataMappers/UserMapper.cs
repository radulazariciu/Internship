using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;
using Samsung.DataLayer;

namespace Samsung.DataLayer.DataMappers
{
    public class UserMapper
    {
   
        public List<User> usersList = new List<User>
        {
            /*new User
            {
               Id = 0,
               FirstName = "TestFM",
               LastName = "TestSN",
               Password = "test",
               EmailAddress = "test@test.com",
               Zipcode = 12345,
               DateOfBirth = DateTime.Today
            }*/
        };

        public void AddUser(User user)
        {
            usersList.Add(user);
            using (var db = new SamsungContext())
            {
                db.Samsung_User.Add(new Samsung_User { id = 1, firstName = "firstName",lastName="lastName",zipCode = 1,dateOfBirth = null,emailAddress = "email@yahoo.com",password = "password"});
                db.SaveChanges();
                int nr = db.Samsung_User.Count();
            }

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

        public List<Samsung_User> GetAllUsers()
        {
            using (var db = new SamsungContext())
            {
                var allRows = db.Samsung_User.ToList();
                return allRows;       
            }
        }
    }
}