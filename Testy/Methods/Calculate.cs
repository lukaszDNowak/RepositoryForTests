using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Testy.Methods
{
    public static class Calculate
    {
        public static long? SumScore (long? value1 , long? value2)
        {

            if(value1==null || value2 == null)
            {
                throw new ArgumentNullException();
            }
            else return value1 + value2;             
    }
  }
}