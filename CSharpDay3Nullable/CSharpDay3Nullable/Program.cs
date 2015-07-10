using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay3Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee
            {
                Name = "Bill Gates",
                StartDate = DateTime.Parse("April 4, 1975"),
                EndDate = DateTime.Parse("January 1, 2000")
            };

            DateTime endDate = emp1.EndDate.GetValueOrDefault(DateTime.Now);





            if (emp1.EndDate != null)
            {
                Console.WriteLine("End date was " + emp1.EndDate);
            }
            if (emp1.EndDate.HasValue)
            {
                Console.WriteLine("End date was " + emp1.EndDate);
            }

            int result = 0;

            if (int.TryParse("45", out result))
            {

            }



            Console.ReadLine();
        }
    }
}
