using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _17._10._2019
{
    class dz
    {
        Random rnd = new Random();
        public void Task1()
        {
            List<int> data = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                data.Add(rnd.Next(-200,200));
            }

            var ndata = from t in data
                                where t > 0
                                orderby t 
                                select t;

            foreach (var s in ndata)
                Console.WriteLine(s);
        }
        public void Task2()
        {
            List<int> data = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                data.Add(rnd.Next(-200, 200));
            }

            var ndata = from t in data
                        where t > 0
                        select t;
            
                Console.WriteLine("Quantity => "+ ndata.Count()+" | AVG => "+ndata.Average());
        }

        public void Task3()
        {
            List<string> data = new List<string>();
            string buf = "";
            data.Add("w");
            data.Add("sdfgh");
            data.Add("sdffghj");
            data.Add("wert");
            data.Add("erty76");
            data.Add("fgb");
            data.Add("op34e");
            buf = data.Aggregate((x, y) => x + y[0].ToString());

            Console.WriteLine(buf);
        }
        public void Task4()
        {
            List<string> data = new List<string>();
            string buf = "";
            data.Add("w");
            data.Add("sdfgh");
            data.Add("sdffghj");
            data.Add("wert");
            data.Add("erty76");
            data.Add("fgb");
            data.Add("op34e");
            var n=data.SelectMany(p => p[0].ToString()).Reverse();
            foreach (var i in n)
            {
            Console.WriteLine(i);

            }
        }
    }
}
