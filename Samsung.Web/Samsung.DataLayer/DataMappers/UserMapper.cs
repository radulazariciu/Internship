using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Samsung.DataLayer.Models;

namespace Samsung.DataLayer.DataMappers
{
    public class UserMapper
    {
        public User LoggedUser { get; set; }
    
        public List<Samsung_User> usersList = new List<Samsung_User>();

        public void AddUser(User user)
        {

            Samsung_User samsungUser = new Samsung_User(user.FirstName,user.LastName, user.Zipcode, user.DateOfBirth, user.EmailAddress, user.Password);
            usersList.Add(samsungUser);
            using (var db = new EntitySamsung())
            {
                db.Samsung_User.Add(samsungUser);
            }

           
        }

        public Boolean CheckUserExistence(Samsung_User user)
        {

            List<Samsung_User> checkSamsungUsersList = GetAllSamsungUsers();

            foreach (var item in checkSamsungUsersList)
            {
                if (item.emailAddress.Equals(user.emailAddress))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddUser(Samsung_User user)
        {
            using (var db = new EntitySamsung())
            {
                db.Samsung_User.Add(user);
                db.SaveChanges();
            }
        }

        public List<Samsung_User> GetAllSamsungUsers()
        {
            using (var db = new EntitySamsung())
            {

                return db.Samsung_User.ToList();
            }
        }
    }
}