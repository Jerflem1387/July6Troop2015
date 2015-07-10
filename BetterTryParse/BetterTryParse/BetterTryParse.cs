using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterTryParse
{
    public static class StringExtensions
    {
        public static int? TryParseAsInt(this string value)
        {
            int result = 0;
            //SHORTHAND if else statment
            //return int.TryParse(value, out result) ? result : default(int?);        
            if (int.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return null;
            }

        }
    }
}
