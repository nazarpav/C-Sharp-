using System;
using System.Collections.Generic;
using System.Text;

namespace _18._09._2019
{
    class Circle : Figure
    {
        double A;
        public Circle(double a)
        {
            A = a;
        }
        public override double PFigure() =>Math.PI*A*2 ;

        public override double SFigure() => Math.Pow((Math.PI*A),2);
    }
}
