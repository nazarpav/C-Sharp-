using System;

namespace _26._09._2019
{/*Завдання:
Створити generic клас який описує відрізок (пряма на площині). В класі передбачити 2 поля типу generic точки - точки, через які проходить пряма.
Реалізувати в класі:
- конструктор, який приймає 2 точки
- конструктор, який приймає 4 координати (x і у координати для першої і другої точки)
- метод ToString ()*/
    class Program
    {

        static void Main(string[] args)
        {
            //string text = "Ось будинок, який побудував Джек. А це пшениця, яка в темній комірці зберігається у будинку, який побудував Джек";
            //Console.WriteLine(text.CounterWord());
            Generic<int> obj=new Generic<int>(new Point<int>(3,3), new Point<int>(3, 3));
            Console.WriteLine(obj.ToString());
        }
    }
}
