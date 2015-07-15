using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models
{
    public class User
    {
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
    }
}