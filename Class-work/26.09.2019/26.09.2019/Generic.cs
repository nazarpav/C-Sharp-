using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2019
{
    /*Завдання:
Створити generic клас який описує відрізок (пряма на площині). В класі передбачити 2 поля типу generic точки - точки, через які проходить пряма.
Реалізувати в класі:
- конструктор, який приймає 2 точки
- конструктор, який приймає 4 координати (x і у координати для першої і другої точки)
- метод ToString ()*/
    class Point<T> where T : struct
    {
        public T X { get; set; }
        public T Y { get; set; }

        // Default ctor
        public Point()
        {
            // X = 0;       // error
            // Y = null;    // error
            X = default(T);
            Y = default(T);
        }

        public Point(T x, T y)
        {
            this.X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }
    class Generic<T> where T :struct
    {
        Point<T> p1;
        Point<T> p2;
        public Generic(Point<T> p1, Point<T> p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public Generic(T  x1,T  y1,T x2,T y2)
        {
            p1 = new Point<T>(x1,y1);
            p2 = new Point<T>(x2, y2);
        }
        public override string ToString()
        {
            return ($" X1=> {this.p1.X}" + $" Y1=> {this.p1.Y}" +  $" X2=> {this.p2.X}"  + $" Y2=> {this.p1.X}");
        }
    }
}
