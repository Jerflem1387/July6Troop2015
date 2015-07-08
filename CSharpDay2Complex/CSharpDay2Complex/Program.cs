using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer
            {
                BillingAddress =
                {
                    City = "houston",
                    Street = "223 lsjkdf",
                    Zip = "77845"
                },
                ShippingAddress =
                {
                    City = "Seabrook",
                    Street = "nasa pky",
                    Zip = "77845"
                },
                FirstName = "Jeremy",
                LastName = "Fleming"
            };
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public Customer()
        {
            BillingAddress = new Address();
            ShippingAddress = new Address();
        }

    }
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

    }

}
