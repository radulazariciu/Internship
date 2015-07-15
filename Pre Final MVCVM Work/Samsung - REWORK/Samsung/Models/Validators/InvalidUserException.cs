using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models.Validators
{
    public class InvalidUserException :Exception
    {
        private string exceptionMessage;
        public InvalidUserException(string Message)
            :base(Message)
        {
            this.exceptionMessage = Message;
        }

        public string Message 
        { 
            get
            {
                return this.exceptionMessage;
            }  
        }
    }
}