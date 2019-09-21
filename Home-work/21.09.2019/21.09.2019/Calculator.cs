using System;
using System.Collections.Generic;
using System.Text;

namespace _21._09._2019
{
    class Calculator
    {
        private const string Value = "Enter num1 and num2 : \n";

        private double Add(double num1, double num2) => num1 + num2;
        private double Sub(double num1, double num2) => num1 - num2;
        private double Mul(double num1, double num2) => num1 * num2;
        private double Div(double num1, double num2)
        {
            if (num2 == 0)
                throw new Exception("num2 is 0");
            return num1 / num2;
        }

        public void Start()
        {
            double num1 = 0;
            double num2 = 0;
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(Value);
                    if (double.TryParse(Console.ReadLine(), out num1) && double.TryParse(Console.ReadLine(), out num2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error!!! ");
                        _ = Console.ReadKey();
                    }
                }
                Console.Clear();
                Console.WriteLine($"Num1: {1}" + $"Num2: {2}", num1, num2);
                Console.Write("1: +\n2: -\n3: *\n4: /\n: ");

                switch (Console.ReadKey().KeyChar)
                {
                    case (char)27:
                        return;
                        break;
                    case '1':
                        Console.WriteLine("\nResult: " + Add(num1, num2));
                        break;
                    case '2':
                        Console.WriteLine("\nResult: " + Sub(num1, num2));
                        break;
                    case '3':
                        Console.WriteLine("\nResult: " + Mul(num1, num2));
                        break;
                    case '4':
                        try
                        {
                            Console.WriteLine("\nResult: " + Div(num1, num2));
                        }
                        catch
                        {
                            Console.WriteLine("Division on zero");
                            _ = Console.ReadKey();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid key");
                        break;

                }
            _=Console.ReadKey();
            }

        }
    }

}

