using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2019
{
    class Rectangle
    {
        private int _a, _b;
        public Rectangle(int A,int B)
        {
            this.A = A;
            this.B = B;
        }
        public int A { get => _a; set => _a = value; }
        public int B { get => _b; set => _b = value; }
        public override string ToString() => ($"A: {A} | B: {B}");
        public override bool Equals(object obj)
        {
            Rectangle rect = (Rectangle)obj;
            return A == rect?.A && B == rect?.B;
        }
        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }
        public static Rectangle operator ++(Rectangle rect)
        {
            rect.A++;
            rect.B++;
            return rect;
        }
        public static Rectangle operator --(Rectangle rect)
        {
            rect.A--;
            rect.B--;
            return rect;
        }
        public static Rectangle operator -(Rectangle rect) => new Rectangle(rect.A * -1, rect.B * -1);
        public static Rectangle operator +(Rectangle rect, Rectangle rect2) => new Rectangle(rect.A + rect2.A, rect.B + rect2.B);
        public static Rectangle operator -(Rectangle rect, Rectangle rect2) => new Rectangle(rect.A - rect2.A, rect.B - rect2.B);
        public static Rectangle operator *(Rectangle rect, Rectangle rect2) => new Rectangle(rect.A * rect2.A, rect.B * rect2.B);
        public static Rectangle operator /(Rectangle rect, Rectangle rect2) => new Rectangle(rect.A / rect2.A, rect.B / rect2.B);
        public static bool operator >(Rectangle rect, Rectangle rect2) => rect.A + rect.B > rect2.A + rect2.B;
        public static bool operator <(Rectangle rect, Rectangle rect2) => !(rect>rect2);
        public static bool operator >=(Rectangle rect, Rectangle rect2) => rect.A + rect.B > rect2.A + rect2.B||rect.Equals(rect2);
        public static bool operator <=(Rectangle rect, Rectangle rect2) => !(rect > rect2) || rect.Equals(rect2);
        public static bool operator ==(Rectangle rect, Rectangle rect2) => rect.Equals(rect2);
        public static bool operator !=(Rectangle rect, Rectangle rect2) => !(rect==rect2);
        public static bool operator true(Rectangle rect) => rect.A != 0 || rect.B != 0;
        public static bool operator false(Rectangle rect) => rect.A == 0 && rect.B == 0;
        public static implicit operator Square(Rectangle rect) => new Square(rect.A+rect.B/2);

        public static explicit operator int (Rectangle rect)=>rect.A * rect.B;


    }
}
