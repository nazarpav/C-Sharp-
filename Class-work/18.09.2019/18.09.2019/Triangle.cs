using System;
using System.Collections.Generic;
using System.Text;

namespace _18._09._2019
{
    class Triangle : Figure
    {
        double A, B;
        public Triangle(double a, double b )
        {
            A = a;
            B = b;
        }
        public override double PFigure() => Math.Sqrt(A * A + B * B) + A + B;

        public override double SFigure() => A * B / 2;
    }
}
