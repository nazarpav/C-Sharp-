using System;
using System.Collections.Generic;
using System.Text;

namespace _18._09._2019
{
    class Ellipse : Figure
    {
        double A, B;
        public Ellipse(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double PFigure() => 4*((Math.PI*A*B+(A-B))/(A+B));

        public override double SFigure() => A * B* Math.PI;
    }
}
