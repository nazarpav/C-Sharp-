using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Animal:Creature
    {
        protected readonly Animal_ _type;
        protected readonly string _animalVoise;
        public Animal (Animal_ type, string animalVoise)
        {
            this._animalVoise = animalVoise;
            this._type = type;
        }
        public virtual bool IsAnimal() => true;
        public virtual Animal_ GetAnimalType()=> _type;
        public virtual string Voise() => _animalVoise;
    }
}
