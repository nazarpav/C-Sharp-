using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPerevantajennya
{
    class Square
    {
        public int A;
        public override string ToString()
        {
            return $"Point: size: {A}";
        }
        public override bool Equals(object obj)
        {
            Square point = (Square)obj;
            return A == point?.A;
        }
        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            return hashCode;
        }
​
        public static Square operator ++(Square tmp)
        {
            Square newTmp = new Square(tmp.A + 1);
            return newTmp;
        }
        public static Square operator --(Square tmp)
        {
            Square newTmp = new Square(tmp.A - 1);
            return newTmp;
        }
​
        public static Square operator +(Square tmp, Square tmp2)
        {
            Square newTmp = new Square(tmp.A + tmp2.A);
            return newTmp;
        }
        public static Square operator -(Square tmp, Square tmp2)
        {
            Square newTmp = new Square(tmp.A - tmp2.A);
            return newTmp;
        }
​
        public static Square operator *(Square tmp, Square tmp2)
        {
            Square newTmp = new Square(tmp.A * tmp2.A);
            return newTmp;
        }
        public static Square operator /(Square tmp, Square tmp2)
        {
            Square newTmp = new Square(tmp.A / tmp2.A);
            return newTmp;
        }
​
        public static bool operator ==(Square tmp, Square tmp2)
        {
            return tmp.Equals(tmp2);
        }
        public static bool operator !=(Square tmp, Square tmp2)
        {
            return !tmp.Equals(tmp2);
        }
​
        public static bool operator true(Square tmp)
        {
            return tmp.A != 0;
        }
        public static bool operator false(Square tmp)
        {
            return tmp.A == 0;
        }
​
        public static explicit operator int(Square tmp)
        {
            return tmp.A;
        }
        public Square(int a) => A = a;
    }
}
