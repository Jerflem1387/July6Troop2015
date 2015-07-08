using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Utility.CleanUserInput("   klj;aLKJfkakf   ");
        }
    }

    class Counter
    {
        public static int CountWords(string input)
        {
            MatchCollection collection = Regex.Matches(input, @"[\S]+");
            return collection.Count;
        }
    }
    
    
    
    class Utility
    {
        public static string CleanUserInput(string input)
        {
            return input.ToLower().Trim();
        }
    }


}



