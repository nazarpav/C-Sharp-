using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Bear : Mammal, Running
    {
        public Bear(Animal_ type, string animalVoise) : base(type, animalVoise) { }
        public string Run()
        {
            return "Run";
        }
    }
}
