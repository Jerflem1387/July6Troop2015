﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Eagle : IAnimal, IBird
    {
        public string Name { get; set; }
        public string MakeSound()
        {
            return "Screeech";
        }
        
    }
}
