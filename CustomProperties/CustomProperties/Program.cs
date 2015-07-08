using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomProperties
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "age cannot be younger than 0");
                }
                _age = value;
            }
        }
        
        public DateTime Birthdate { get; set; }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer
            {
                FirstName = "Sally",
                LastName = "Williams",
                Age = 20,
                Birthdate = DateTime.Parse("2028-01-01")
            };
            Customer cust2 = new Customer
            {
                FirstName = "Mike",
                LastName = "Harrison",
                Age = 10,
                Birthdate = DateTime.Parse("2019-01-01")
            };

            Debug.Assert(cust1.Age == 23, "Sally is 23");
            Debug.Assert(cust2.Age == 10, "Mike is 10");
            
            Console.WriteLine(String.Format("{0} {1} who is age {2} and was born in {3}", cust1.FirstName, cust1.LastName, cust1.Age, cust1.Birthdate));
            Console.WriteLine(String.Format("{0} {1} who is age {2} and was born in {3}", cust2.FirstName, cust2.LastName, cust2.Age, cust2.Birthdate));

            

            Console.ReadLine();
        }
    }
}
