using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class AnimalUtility
    {
        public static void DoSomething(IAnimal animal)
        {
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.MakeSound());

            if (animal is IBird)
            {
                Console.WriteLine("Flap Flap Flap");
            }
        }
    }
}
