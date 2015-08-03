using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetDay1Intro.Models
{
    public class Customer
    {
        public Customer()
        {
            ShippingAddress = new Address();
            BillingAddress = new Address();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}