using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models
{
    public class UserCellPhone
    {
        public string FirstPartCellPhone { get; set; }
        public string SecondPartCellPhone { get; set; }
        public string ThirdPartCellPhone { get; set;  }

        public UserCellPhone(string FirstPartCellPhone,string SecondPartCellPhone, string ThirdPartCellPhone)
        {
            this.FirstPartCellPhone = FirstPartCellPhone;
            this.SecondPartCellPhone = SecondPartCellPhone;
            this.ThirdPartCellPhone = ThirdPartCellPhone;
        }
    }
}