using System;
using System.Collections.Generic;
using System.Text;

namespace _18._09._2019
{
    class Trapezoid : Figure
    {
        double A, B, C;
        public Trapezoid(double a, double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double PFigure() => Math.Sqrt(Math.Pow(((B-A)/2),2)+(C*C))*2+A+B;

        public override double SFigure() => ((A + B) / 2) * C;
    }
}
