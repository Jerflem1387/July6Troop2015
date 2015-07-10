using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLookupWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> states = new Dictionary<string, string>();
            states.Add("ca", "California");
            states.Add("tx", "Texas");
            states.Add("wa", "Washington");

            string texas = states["tx"];

            if (states.ContainsKey("tx"))
                Console.WriteLine("We have texas");
            if(states.ContainsValue("Texas"))
                Console.WriteLine("We have texas");

            string value = null;
            if(states.TryGetValue("tx", out value))
                Console.WriteLine("We have texas");

            Console.ReadLine();
        }
    }
}
