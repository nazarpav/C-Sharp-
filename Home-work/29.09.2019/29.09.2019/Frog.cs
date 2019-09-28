using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Frog : Reptile, Creeping
    {
        public Frog(Animal_ type, string animalVoise) : base(type, animalVoise) { }
        public string Creps()
        {
            return "Creeps";
        }
    }
}
