using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            calc obj=new calc();
            //Console.WriteLine(obj.Сalculation('+', 1, 2));
            //Console.WriteLine(obj.СalculationTrig("Sin", 1));
            string buf="";
            string buf2="";
            string buf3="";
            string type="";
            bool flag = false;
            buf=Console.ReadLine();
            foreach(var n in buf)
            {
                if(char.IsDigit(n))
                {
                    if (flag = true)
                        buf3 += n;
                    else
                        buf2 += n;
                }
                else if (n=='+'|| n == '-'||n == '/'|| n == '*')
                {
                    flag = true;
                    if (type == "")
                        type += n;
                    else
                        break;
                }

              
            }
            Console.WriteLine(obj.Сalculation(char.Parse(type),double.Parse(buf2), double.Parse(buf3)));
            Console.ReadKey();
            double num1=0;
            double num2=0;
            char oper;
            //string type;
            Console.WriteLine("Trig -1 or arfet - 2 ");
            double.TryParse(Console.ReadLine(), out num1);
            switch (num1)
            {
                case 1:
                    Console.WriteLine("Enter num : ");
                    double.TryParse(Console.ReadLine(), out num1);
                    Console.WriteLine("Enter oeration: (Sin,Cos,Tan) => ");
                    type = Console.ReadLine();
                    Console.WriteLine(obj.СalculationTrig(type, num1));
                    break;
                case 2:
                    Console.WriteLine("Enter num1 : ");
                    double.TryParse(Console.ReadLine(), out num1);
                    Console.WriteLine("Enter num2 : ");
                    double.TryParse(Console.ReadLine(), out num2);
                    Console.WriteLine("Enter oeration: (+,-,*,/) => ");
                    char.TryParse(Console.ReadLine(), out oper);
                    Console.WriteLine(obj.Сalculation(oper, num1, num2));
                    break;
                default:
                    break;
            }
            
        } 

    }
}
