using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Samsung.BusinessLogic.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }

        public LoginVM(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }

        public LoginVM()
        {
        }
    }
}