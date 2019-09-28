using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Eagle : Birdie, Flying
    {
        public Eagle(Animal_ type, string animalVoise) : base(type, animalVoise) { }
        public string Fly()
        {
            return "Fly";
        }
    }
}
