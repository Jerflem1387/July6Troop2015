using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newsArray = new string[]{
                "Martians Attack!",
                "Seahawks lose the Superbowl",
                "Texans Might win a game this year"
            };
            Console.WriteLine(newsArray.GetRandom());


            Console.ReadLine();
        }
    }
}
