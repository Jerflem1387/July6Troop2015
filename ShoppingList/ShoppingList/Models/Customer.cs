using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class Customer
    {
        public Customer()
        {
            ListOfProducts = new List<Products>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Products> ListOfProducts { get; set; }
        

    }
}