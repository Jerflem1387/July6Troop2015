using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxRules
{
    public class Tax
    {
        private DateTime _currentDate;

        public Tax(DateTime currentDate)
        {
            _currentDate = currentDate;
        }


        public decimal Calculate(decimal price, DateTime birthDate, string firstName, string lastName)
        {
            decimal taxAmount = 0;

            if ((DateTime.Now.Year - birthDate.Year) < 5)
                return taxAmount;
            taxAmount = taxAmount * .08m;

            if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                taxAmount += taxAmount;

            if (firstName.ToLower().StartsWith("J"))
                taxAmount += taxAmount;

            if (lastName.ToLower().StartsWith("W"))
                taxAmount -= 1;
            return taxAmount >= 0 ? taxAmount : 0;



        }
    }
}
