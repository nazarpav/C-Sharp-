using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Mammal: Animal
    {
        public Mammal(Animal_ type, string animalVoise) : base(type, animalVoise) { }
        public override bool IsAnimal() => true;
        public override Animal_ GetAnimalType() => _type;
        public override string Voise() => _animalVoise;
    }
}
