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
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            FourthTask();


        }
        static void FirstTask()
        {
            string str1 = "qewq";//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            string str2 = "qewwq";
            str2.Intersect(str1).ToList().ForEach(Console.Write);
        }
        static void SecondTask()
        {
            string palindrom = "aqqeqq";//<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

            char[] charArray = palindrom.ToCharArray();
            Array.Reverse(charArray);
            string s = string.Join(String.Empty, charArray);
            Console.WriteLine((s==palindrom?"true":"false"));
        }

        static bool Predicat(char chr)
        {
            if (chr == ' ')
                return true;
            else
                return false;
        }
        static void ThirdTask()
        {
            string str = "h h h    gfdg       dgkjdsfks         ";//<<<<<<<<<<<<<<<<<<<<<<<<<<<
            str = string.Join(' ', str.Split(' ', StringSplitOptions.RemoveEmptyEntries));
            short quantityWord = (short)(string.IsNullOrEmpty(str)?0:1);

            char[] findChars = Array.FindAll(str.ToCharArray(), Predicat);
            quantityWord += (short)findChars.Length;
            Console.Write("Quantity word=> "+quantityWord);

        }

        static void MinMax(out int min,out int max,ref int[][] arr,int size)
        {
            int min_ = int.MaxValue, max_ = int.MinValue;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i][j] < min_)
                    {
                        min_ = arr[i][j];
                    }

                    if (arr[i][j] > max_)
                    {
                        max_ = arr[i][j];
                    }
                }
            }
            min = min_;
            max = max_;
        }
        static void FourthTask()
        {
            const short size = 5;
            var random = new Random();
            int[][]array= new int[size][];
            for (int i = 0; i < size; i++)
            {
                array[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    array[i][j] = (short)((random.Next(200))-100);
                    Console.Write(array[i][j] + "\t");
                }
                Console.WriteLine();
            }
                Console.WriteLine("=========================================================");

            MinMax(out int min, out int max, ref array, size);
           
            bool flag = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(flag)
                    Console.Write(array[i][j] + "\t");
                    if (array[i][j] == min || array[i][j] == max)
                        flag = !flag;
                }
                Console.WriteLine();
            }
            Console.WriteLine("min=> "+min+"max=> "+max);
        }
    }
}
