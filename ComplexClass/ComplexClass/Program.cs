using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer
            {
                FirstName = "Alice",
                Checking = 
                {
                    Id = "My checking",
                    Amount = 100.00m,
                    IsOpen = true,
                    Type = AccountType.Checking

                },
                Savings =
                {
                    Amount = 0.00m,
                    Id = "My Savings",
                    IsOpen = false,
                    Type = AccountType.Savings
                }
            };
            cust1.Transfer(50m, AccountType.Checking, AccountType.Savings);

            Console.WriteLine(cust1.Checking.Amount);
            Console.WriteLine(cust1.Savings.Amount);
            Console.ReadLine();
        }
    }


    enum AccountType
    {
        Checking,
        Savings
    }
    
    
    class Customer
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account Checking { get; set; }
        public Account Savings { get; set; }
        public Customer()
        {
            Checking = new Account();
            Savings = new Account();
        }
        public void Transfer(decimal number, AccountType from, AccountType to)
        {
            if(from == AccountType.Checking && to == AccountType.Savings)
            {
                Checking.Amount -= number;
                Savings.Amount += number;
            }
            else if (from == AccountType.Savings && to == AccountType.Checking)
            {
                Savings.Amount -= number;
                Checking.Amount += number;
            }
        }

    }
    class Account
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }
        public AccountType Type { get; set; }

    }

}
