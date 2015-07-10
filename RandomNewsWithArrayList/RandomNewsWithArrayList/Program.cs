using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNewsWithArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> random = new List<string>();
            random.Add("Martians attack!");
            random.Add("today is Friday");
            random.Add("Tomorrow is Saturday");

            Random rand = new Random();
            int result = rand.Next(3);



            





        }
    }
}
