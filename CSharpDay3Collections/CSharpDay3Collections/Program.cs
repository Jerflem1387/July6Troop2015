using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay3Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Name = "Bill Gates" });
            customers.Add(new Customer { Name = "Steve Jobs" });

            foreach (Customer item in customers)
            {
                Console.WriteLine(item.Name);
            }
           
            
            
            
            
            
            
            
            Console.ReadLine();






        }
    }
}
