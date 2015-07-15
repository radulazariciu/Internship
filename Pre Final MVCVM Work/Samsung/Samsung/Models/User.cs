using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models
{
    public class User
    {
<<<<<<< HEAD
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public UserDateOfBirth DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
        public UserCellPhone CellPhone { get; set; }
        public string ZipCode { get; set; }
        public string Password { get; set; }

        public User(string FirstName,string SecondName,UserDateOfBirth DateOfBirth,string EmailAddress,UserCellPhone CellPhone,string ZipCode,string Password)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.DateOfBirth = DateOfBirth;
            this.EmailAddress = EmailAddress;
            this.CellPhone = CellPhone;
            this.ZipCode = ZipCode;
            this.Password = Password;
        }
=======
        public int Id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string cellPhone { get; set; }
        public int zipCode { get; set; }
>>>>>>> 88e733912c7fd449e56c94f6fe867a5f49ca79fa
    }
}