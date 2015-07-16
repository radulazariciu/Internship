using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Samsung.Models.Helpers
{
    public class ReferenceData
    {
        public Dictionary<string,string> GetDays()
        {
            return new Dictionary<string, string>() { { "1", "Monday" }, { "2", "Tuesday" } };
        }
    }
}