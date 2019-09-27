using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2019
{
    class Square
    {
        private int _a;
        public Square(int A)
        {
            this.A = A;
        }
        public int A { get => _a; set => _a = value; }
        public override string ToString() => ($"A: {A}");
        public override bool Equals(object obj)
        {
            Square square = (Square)obj;
            return A == square?.A;
        }
        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + A.GetHashCode();
            return hashCode;
        }
        public static Square operator ++(Square square)
        {
            square.A++;
            return square;
        }
        public static Square operator --(Square square)
        {
            square.A--;
            return square;
        }
        public static Square operator -(Square square) => new Square(square.A * -1);
        public static Square operator +(Square square, Square square2) => new Square(square.A + square2.A);
        public static Square operator -(Square square, Square square2) => new Square(square.A - square2.A);
        public static Square operator *(Square square, Square square2) => new Square(square.A * square2.A);
        public static Square operator /(Square square, Square square2) => new Square(square.A / square2.A);
        public static bool operator >(Square square, Square square2) => square.A> square2.A;
        public static bool operator <(Square square, Square square2) => !(square > square2);
        public static bool operator >=(Square square, Square square2) => square.A > square2.A||square.Equals(square2);
        public static bool operator <=(Square square, Square square2) => !(square > square2) || square.Equals(square2);
        public static bool operator ==(Square square, Square square2) => square.Equals(square2);
        public static bool operator !=(Square square, Square square2) => !(square == square2);
        public static bool operator true(Square square) => square.A != 0;
        public static bool operator false(Square square) => square.A == 0;
        public static explicit operator Rectangle(Square square) => new Rectangle(square.A, square.A);
        public static implicit operator int(Square square) => square.A * square.A;
    }
}
