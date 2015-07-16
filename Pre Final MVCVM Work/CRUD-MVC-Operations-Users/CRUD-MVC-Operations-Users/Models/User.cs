using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace CRUD_MVC_Operations_Users.Models
{
    public class User
    {
        private List<User> userList = new List<User>();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User getUser(int id)
        {
            User userReturn = new User();
            foreach (User u in userList)
            {
                System.Console.Write(u.Name);
                if (id == u.ID) 
                {
                    return u;
                }
            }
            return null;
        }

        public void addUser(int id, string name, string email, string password)
        {
            User newUser = new User();
            newUser.ID = id;
            newUser.Name = Name;
            newUser.Email = email;
            newUser.Password = password;
        }


        public void editUser(int id, string name, string email, string password)
        {
            int i = 0;
            foreach (User u in userList)
            {
                i++;
                System.Console.Write(u.Name);
                if (id == u.ID)
                {
                    u.Name = Name;
                    u.Email = email;
                    u.Password = password;
                    userList[i] = u;
                }
            }
        }


        public void deleteUser(int id)
        {
            foreach (User u in userList)
            {
                
                System.Console.Write(u.Name);
                if (id == u.ID)
                {
                    userList.Remove(u);
                }
            }
        }

    }
}