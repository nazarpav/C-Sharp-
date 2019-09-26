using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2019
{
    class Rectangle
    {
        private int A, B;
        public Rectangle(int A,int B)
        {
            this.A = A;
            this.B = B;
        }
        public int A1 { get => A; set => A = value; }
        public int B1 { get => B; set => B = value; }
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

    }
}
