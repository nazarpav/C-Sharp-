using System;
using System.Collections.Generic;
using System.Text;

namespace _18._09._2019
{
    class Rectangle : Figure
    {
        double A, B;
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double PFigure() => Math.Sqrt(A * A + B * B) + A + B;

        public override double SFigure() => A * B;
    }
}
