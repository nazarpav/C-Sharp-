using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2019
{
    class Rectangle
    {
        private int A, B;

        public int A1 { get => A; set => A = value; }
        public int B1 { get => B; set => B = value; }
        public override string ToString() => ($"A: {A} | B: {B}");

        public override bool Equals(object obj)
        {
            Rectangle rect = (Rectangle)obj;
            return A == rect?.A && B == rect?.B;
        }​
        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            hashCode = hashCode * -1521134295 + B.GetHashCode();
            return hashCode;
        }
    }
}
