using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee bill = new FullTimeEmployee();
            bill.FirstName = "Bill";
            bill.LastName = "Gates";
            bill.YearsEmployed = 5;

            ContractEmployee steve = new ContractEmployee();
            steve.FirstName = "Steve";
            steve.LastName = "Jobs";
            steve.MonthsEmployed = 2;

            Console.WriteLine("{0} has been employed for {1} years", bill.ShowFullName(), bill.YearsEmployed);
            Console.WriteLine("{0} has been employed for {1} months", steve.ShowFullName(), steve.MonthsEmployed);
            

            Console.ReadLine();


        }
    }

    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShowFullName()
        {
            return FirstName + " " + LastName;
        }

    }

    class FullTimeEmployee : Employee
    {
        public int YearsEmployed { get; set; }
    }
    class ContractEmployee : Employee
    {
        public int MonthsEmployed { get; set; }
    }



}
