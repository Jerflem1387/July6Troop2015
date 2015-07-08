using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            NewCar tesla = new NewCar();
            tesla.Model = "Modle S";
            tesla.Price = 27877.99m;
            tesla.VIN = "2349898wjc8w92r";

            UsedCar usedToyota = new UsedCar();

            CertifiedUsedCar jaguar = new CertifiedUsedCar();

            Car[] inventory = new Car[] 
            {  
                new UsedCar {VIN="78YSDDFSD45", Price=17000m},
                new CertifiedUsedCar {VIN="888SDDFSD45", Price=17000m},
                new NewCar {VIN="YIUIU66II77", Price=44000m},
                new UsedCar {VIN="3NBMM99887", Price=12000m},
                new UsedCar {VIN="55555OOOOOP", Price=11000m}
            
            };

            decimal total = 0;
            foreach (Car car in inventory)
            {
                if (car is UsedCar)
                {
                    total += car.Price;
                }
                
            }

            Console.WriteLine("Total inventory value: " + total.ToString("c"));
            Console.ReadLine();

        }
    }

    abstract class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal CalculateTac()
        {
            return Price * .08m;
        }

    }



    class NewCar : Car
    {

    }
    class UsedCar : Car
    {
        public int Miles { get; set; }
    }
    class CertifiedUsedCar : UsedCar
    {
        public int WarrantyMonths { get; set; }
    }



}
