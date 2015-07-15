using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NikeWebsite.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string ScreenName { get; set; }
        public string Gender { get; set; }
        public int Zipcode { get; set; }
        public DateTime DateOfBirth { get; set; }        
        [DataType(DataType.EmailAddress)]
        [Required]
        public string emailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}