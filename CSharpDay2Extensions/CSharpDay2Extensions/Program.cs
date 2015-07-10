using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Extensions
{
    class Program
    {
        static void Increment(ref int num)
        {
            num++;
        }


        static void Main(string[] args)
        {

            int num = 10;
            Increment(ref num);
            Console.WriteLine(num);
            
            
            
            
            string message = "Everything is Awsome!".Reverse();
            //  string revMessage = StringUtility.Reverse(message);
            Console.WriteLine(message);





            Console.ReadLine();
        }
    }
}
