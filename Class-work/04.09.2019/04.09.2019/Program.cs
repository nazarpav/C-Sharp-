using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Завдання
Оголосити одновимірний (5 елементів) масив з ім'ям A і двовимірний масив (3 рядки, 4 стовбця) дробових чисел з ім'ям B.
Заповнити одновимірний масив А числами, 
введеними з клавіатури користувачем, а двовимірний масив В випадковими числами (-100 ... 100) за допомогою циклів.
Вивести на екран значення масивів: масиву А в один рядок, масиву В - у вигляді матриці. Знайти в даних масивах загальний максимальний елемент, 
мінімальний елемент, загальну суму всіх елементів, суму парних елементів масиву А, суму непарних стовпців масиву В.*/
namespace _04._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            byte size_a = 5;
            byte size_x = 4, size_y = 3;
            int sum_all_elem_arrA = 0;
            int sum_all_elem_arrB = 0;

            int sum_all_not_pair_collum_arrA = 0;
            int sum_all_not_pair_collum_arrB = 0;

            int sum_all_pair_elem_arrA = 0;
            int sum_all_pair_elem_arrB = 0;

            int[] A = new int[size_a];
            int[,] B = new int[size_y, size_x];


            for (int i = 0; i < size_a; i++)
            {
                Console.WriteLine("Enter num=> ");
                A[i] = int.Parse(Console.ReadLine());
                sum_all_elem_arrA += A[i];
                if (A[i] % 2 == 0)
                {
                    sum_all_pair_elem_arrA = A[i];
                }
                if (i % 2 == 1)
                {
                    sum_all_not_pair_collum_arrA = A[i];
                }
            }

            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; j < size_x; j++)
                {
                    B[i, j] = rnd.Next(-100, 100);
                    sum_all_elem_arrB += B[i, j];
                    if (B[i, j] % 2 == 0)
                    {
                        sum_all_pair_elem_arrB = B[i, j];
                    }
                    if (j % 2 == 1)
                    {
                        sum_all_not_pair_collum_arrB = B[i, j];
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array a-> \n");

            for (int j = 0; j < size_x; j++)
            {
                Console.Write(A[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Array b-> \n");
            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; j < size_x; j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
            Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("sum all element array A=> " + sum_all_elem_arrA);
            Console.WriteLine("sum all element array B=> " + sum_all_elem_arrB);
            Console.WriteLine();
            Console.WriteLine("sum_all_not_pair_collum_arr A=> " + sum_all_not_pair_collum_arrA);
            Console.WriteLine("sum_all_not_pair_collum_arr B=> " + sum_all_not_pair_collum_arrB);
            Console.WriteLine();
            Console.WriteLine("sum_all_pair_elem_arr A=> " + sum_all_pair_elem_arrA);
            Console.WriteLine("sum_all_pair_elem_arr B=> " + sum_all_pair_elem_arrB);
            Console.WriteLine();
            Console.WriteLine("max element arr A=> " + A.Max());
            Console.WriteLine("min element arr A=> " + A.Min());
            Console.WriteLine("max element arr B=> " + B.Cast<int>().Max());
            Console.WriteLine("min element arr B=> " + B.Cast<int>().Min());



        }
    }
}
