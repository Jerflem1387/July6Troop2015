using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDay2Continued
{
    class Product
    {
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public string Name { get; set; }
        public string Description { get; private set; }

        public Product(string name, decimal price, int unitsInStock) : this(name, price, unitsInStock, null)
        {
            

        }
        public Product(string name, decimal price, int unitsInStock, string description)
        {
            Price = price;
            UnitsInStock = unitsInStock;
            Name = name;
            Description = description;

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Apple", 0.99m, 204);
            Product product2 = new Product("Bread", 2.99m, 89, "White bread");
            Console.WriteLine("{0}, {1:c}, {2}", product1.Name, product1.Price, product1.UnitsInStock);
            Console.WriteLine("{0}, {1:c}, {2}, {3}", product2.Name, product2.Price, product2.UnitsInStock, product2.Description);

            product1.Name = "Banana";
            product1.Price = 1.09m;
            product1.UnitsInStock = 99;
            Console.WriteLine("{0}, {1:c}, {2}", product1.Name, product1.Price, product1.UnitsInStock);


            Console.ReadLine();
        }
    }

}