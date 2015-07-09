using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear bear = new Bear();
            bear.Name = "Brown Bear";

            Eagle eagle = new Eagle();
            eagle.Name = "Bald Eagle";

            Chicken chicken = new Chicken();
            chicken.Name = "Rooster";

            AnimalUtility.DoSomething(bear);
            AnimalUtility.DoSomething(eagle);
            AnimalUtility.DoSomething(chicken);


            Console.ReadLine();

        }
    }   
}
