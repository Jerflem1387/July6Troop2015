using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay4Exceptions
{
    class Program
    {
        public static decimal CalculateTotalPriceWithTax(decimal price, decimal taxRate)
        {
            
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("price", "Price Cannot be less then 0");
            }
            if (taxRate > .10m || taxRate < 0)
            {
                throw new ArgumentOutOfRangeException("taxRate", "Tax Rate cannot be greater than 10% or less than 0%");
            }
            return price * taxRate + price;
        }

        static void Main(string[] args)
        {
           
        }
    }
}
