using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models
{
    public class UserDateOfBirth
    {
        public string Month { get; set; }
        public string Year { get; set; }
        public string Day { get; set; }

        public UserDateOfBirth(String Month, string Year, string Day)
        {
            this.Month = Month;
            this.Year = Year;
            this.Day = Day;
        }
    }
}