using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Extensions
{
    static class StringExtensions
    {
        public static string Reverse(this string stringToExtend)
        {
            char[] textArray = stringToExtend.ToCharArray();
            Array.Reverse(textArray);
            return new string(textArray);
        }
    }
}
