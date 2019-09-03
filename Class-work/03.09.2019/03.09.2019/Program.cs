using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine();
            for(int i=0;i<10;i++)
            {
                Console.Write("  ");
                for (int j = 0; j < 20; j++)
                {
                    Console.Write('▓');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
