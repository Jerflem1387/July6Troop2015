using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    static class ArrayRandom
    {
        //public static string GetRandom(this Array stringToDisplay)
        //{
        //    Random rand = new Random();
        //    return stringToDisplay.GetValue(rand.Next(3)).ToString();
        //}
        public static string GetRandom(this string[] stringToDisplay)
        {
            Random rand = new Random();
            return stringToDisplay[rand.Next(stringToDisplay.Length)];
        }
    }
}
