using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.DataLayer.Models
{
    
    public class User
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Zipcode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public User(int id, string firstName, string lastName, int zipcode, DateTime dateOfBirth, string emailAddress, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Zipcode = zipcode;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
            Password = password;
        }

        public User(string firstName, string lastName, int zipcode, DateTime dateOfBirth, string emailAddress, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Zipcode = zipcode;
            DateOfBirth = dateOfBirth;
            EmailAddress = emailAddress;
            Password = password;
        }

        public User()
        {
        }

        public User(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }


    }
}