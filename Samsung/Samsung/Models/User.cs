using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string cellPhone { get; set; }
        public int zipCode { get; set; }
    }
}