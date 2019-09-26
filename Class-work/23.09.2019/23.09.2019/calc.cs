using System;
using System.Collections.Generic;
using System.Text;

namespace _23._09._2019
{
    class calc
    {
        delegate double ArfmOper(double a, double b);
        delegate double TrigOper(double a);
        private Dictionary<char, ArfmOper> arfOper;
        private Dictionary<string, TrigOper> trigOper;
        public calc()
        {
            arfOper = new Dictionary<char, ArfmOper>()
            {
                {'+', Add },
                {'-', Sub },
                {'*', Mul },
                {'/', Div }
            };
            trigOper = new Dictionary<string, TrigOper>()
            {
                {"Sin", Sin },
                {"Cos", Cos },
                {"Tan", Tan }
            };
        }
        public double Сalculation(char operation, double num1, double num2) => arfOper[operation](num1,num2);
        public double СalculationTrig(string operation, double num1) => trigOper[operation](num1);

        private double Sin(double num1) => Math.Sin(num1);
        private double Cos(double num1) => Math.Cos(num1);
        private double Tan(double num1) => Math.Tan(num1);

        private double Mul(double num1, double num2) => num1 * num2;
        private double Add(double num1, double num2) => num1 + num2;
        private double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new Exception("Division by zero");
            }
            return num1 / num2;
        }
        private double Sub(double num1, double num2) => num1 - num2;
    }
}
