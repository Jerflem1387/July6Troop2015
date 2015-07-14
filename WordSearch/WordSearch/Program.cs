using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader;
            if (File.Exists(@"C:\Users\Jeremy\Desktop\hamlet.txt"))
            {
                Console.WriteLine("Enter a word to search");
                string searchForSomething = Console.ReadLine().Trim();
                reader = new StreamReader(@"C:\Users\Jeremy\Desktop\hamlet.txt");
                string coll = reader.ReadToEnd();
                string criteria = @"\b" + searchForSomething + @"\b";
                Regex regex = new Regex(criteria, RegexOptions.IgnoreCase);

                int count = regex.Matches(coll).Count;
                Console.WriteLine(count.ToString());
            }
            Console.ReadLine();
            
        }
    }
}
