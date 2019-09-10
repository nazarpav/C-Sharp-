using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //First_task();
            //Second_task();
            //Third_task();
            Fourth_task();
        }
        public static void First_task()
        {
            ConsoleKeyInfo buf;
            int counter_space = 0;
            while (true)
            {
                buf = Console.ReadKey(true);
                if (buf.KeyChar == ' ')
                    counter_space++;
                if (buf.KeyChar == '.')
                    break;
            }
            Console.WriteLine("Counter space=> "+counter_space+"\n");
            Console.ReadKey(true);
        }
        public static void Second_task()
        {
            string buf="";
            short first=0, second=0;
            buf=Console.ReadLine();
            for (int i = 0; i < buf.Length/2; i++)
            {
                first += (short)buf[i];
            }
            for (int i = buf.Length/2; i < buf.Length; i++)
            {
                second += (short)buf[i];
            }

            Console.WriteLine("Num is luck=> " + (first==second?"true":"false"));
            Console.ReadKey(true);
        }

        public static void Third_task()
        {
            short first_num = 0;
            short second_num = 0;
            Console.Write("Enter first num=> ");
            first_num = short.Parse(Console.ReadLine());
            Console.Write("\nEnter second num=> ");
            second_num = short.Parse(Console.ReadLine());
            Console.Clear();
            for (int i = first_num; i <= second_num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
        public static void Fourth_task()
        {
            string str = "";
            str = Console.ReadLine();
            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.ReadKey(true);
        }
    }
}
