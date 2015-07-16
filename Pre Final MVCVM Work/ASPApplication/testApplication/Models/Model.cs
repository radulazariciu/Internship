using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testApplication.Models
{
    public class Model
    {

        public int GetSum(int LowLimit, int HighLimit)
        {
            int sum = 0;
            for (int i = LowLimit; i<=HighLimit; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}