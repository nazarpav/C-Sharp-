using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Дано 2 масива розмірності M і N. Необхідно переписати в третій масив спільні елементи перших двох масивів без повторень.
2. Користувач вводить рядок. Перевірити, чи є цей рядок паліндромом. паліндромом називається рядок, яка однаково читається зліва направо і справа наліво.
3. Підрахувати кількість слів у введеному реченні.
4. Дано двовимірний масив розмірністю 5 × 5, заповнений випадковими числами з діапазону від -100 до 100.
Визначити суму елементів масиву, розташованих між мінімальним і максимальним елементами. (edited) */
namespace _05._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "qewq";
            string str2 = "qewwq";

            var common = str2.Intersect(str1).ToList();
            common.ForEach(Console.Write);
            Console.WriteLine($"counter: {common.Count}"); 

            string palindrom = "qeq";

            char[] charArray = palindrom.ToCharArray();
            Array.Reverse(charArray);
            string s = string.Join(String.Empty,charArray);
            if (s== palindrom)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");

        }
    }
}
