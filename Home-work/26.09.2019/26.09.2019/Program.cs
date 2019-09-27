using System;

namespace _26._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(111,111);
            Rectangle rect2 = new Rectangle(11112,11112);
            Console.WriteLine(rect);
            Square square = new Square(333);
            Square square2 = new Square(33339);
            Console.WriteLine(square.ToString());
            Console.WriteLine();
            rect++;
            rect--;
            rect--;
            square++;
            square--;
            square--;
            Console.WriteLine(rect);
            Console.WriteLine(square.ToString());
            Console.WriteLine();
            Console.WriteLine(rect>rect2?"rect":"rect2");
            Console.WriteLine(square > square2 ? "square" : "square2");
            Console.WriteLine(rect <= rect2 ? ">=" : "<=");
            Console.WriteLine(square >= square2 ? ">=" : "<=");
            Console.WriteLine(rect);
            Console.WriteLine(square.ToString());
            Console.WriteLine();
            Console.WriteLine(square.GetHashCode());
            Console.WriteLine(rect.GetHashCode());
        }
    }
}
