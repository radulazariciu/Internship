using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class UserVM
    {
        public UserVM(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }

        public string EmailAddress { get; set; }
        public string Password { get; set; }
    }
}