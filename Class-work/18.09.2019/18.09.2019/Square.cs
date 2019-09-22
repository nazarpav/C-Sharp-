using System;
using System.Collections.Generic;
using System.Text;

namespace _18._09._2019
{
    class Square : Figure
    {
        double A, B;
        public Square(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double PFigure() => (A + B)*2;

        public override double SFigure() => A * B;
    }
}
