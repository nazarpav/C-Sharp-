using System;
using System.Collections.Generic;
using System.Text;

namespace _29._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Animal> zoo=new List<Animal>();
            zoo.Add(new Carp(Animal_.Carp, "Тут"));
            zoo.Add(new Dolphin(Animal_.Dolphin, "Присутній"));
            zoo.Add(new Eagle(Animal_.Eagle, "Так"));
            zoo.Add(new Frog(Animal_.Frog, "На місці"));
            zoo.Add(new Bear(Animal_.Bear, "Тут!"));

            foreach (var n in zoo)
            {
                Console.WriteLine(n.GetAnimalType().ToString()+"! Тут?");
                Console.WriteLine(n.Voise());
                Console.WriteLine();
            }
        }
    }
}
