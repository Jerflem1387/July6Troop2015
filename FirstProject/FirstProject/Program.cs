using FirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (File.Exists(@"HelloWorld.txt"))
            //{
            //    Console.WriteLine("File exists!!");
            //}
            //String name = "Jeremy";
            //Int32 number = 12;

            //string name2 = "Jeremy";
            //int number2 = 13;
            //bool isTodayFriday = false;
            //DateTime today = DateTime.Now;

            //Console.WriteLine("Enter the first number:");
            //int firstNum = 0;
            //bool firstNumIsNumber = int.TryParse(Console.ReadLine(), out firstNum);

            //Console.Write("Enter the second number:");
            //int secondNum = 0;
            //bool secondNumIsNumber = int.TryParse(Console.ReadLine(), out secondNum);

            ////display the results
            //if (firstNumIsNumber && secondNumIsNumber) 
            //{
            //    int result = firstNum + secondNum;
            //    Console.WriteLine("The result is " + result.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("You did not enter valid number");
            //}
            Console.WriteLine("what is todays date");
            DateTime now = DateTime.Now;
            string result = "";
            result = Console.ReadLine();
            now = DateTime.Parse(result);
            Console.Write(now.ToLongDateString());







            //DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;


            //string dinner = "";
            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        dinner = "Steak";
            //        break;
            //    case DayOfWeek.Friday:
            //        dinner = "Chicken";
            //        break;
            //    default:
            //        dinner = "Pasta";
            //        break;
            //}

            //Console.WriteLine(dinner);


            Console.ReadLine();

        }
    }
}
