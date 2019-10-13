using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _13._10._2019
{
    class Regular
    {
        public object Enviroment { get; private set; }

        public void Task1()
        {
            string str = System.IO.File.ReadAllText("Task1.txt");
            Regex regex = new Regex(@"\S*\w*\S*");
            MatchCollection matches = regex.Matches(str);
            str = "";
            foreach (Match i in matches)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                string b = i.Value;
                b=b.Remove(0, 1);
                b=b.Insert(0, i.Value.ToString().ToUpper()[0].ToString());
                str += b;
                str += ".\r\n";
            }
            System.IO.File.WriteAllText("Task1.txt", str);
        }
        public void Task2()
        {
            string str = System.IO.File.ReadAllText("Task2.txt");
            Regex regex = new Regex(@"\d*[.]\d*|\d*[,]\d*");
            MatchCollection matches = regex.Matches(str);
            str = "";
            foreach (Match i in matches)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                str += i.Value;
                str += '\n';
            }
            Console.WriteLine(str);
        }
        public void Task3()
        {
            string[] netsenzur = System.IO.File.ReadAllLines("Netsenzur.txt");
            string str = System.IO.File.ReadAllText("Task3.txt");
            List<Regex> regex = new List<Regex>(); 
            for (int i = 0; i < netsenzur.Length; i++)
            {
                regex.Add(new Regex(@" ?"+ netsenzur[i] + " ?"));
            }
            string newstr = str;
            foreach (var i in regex)
            newstr = i.Replace(newstr, "*");
            System.IO.File.WriteAllText("Task3New.txt", newstr);
        }
        public void Task4()
        {
            string str = System.IO.File.ReadAllText("Task4.txt");
            List<int> intCollection = new List<int>();
            Regex regex = new Regex(@"\d*");
            MatchCollection matches = regex.Matches(str);
            str = "";
            foreach (Match i in matches)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                intCollection.Add(int.Parse(i.Value));
            }
            foreach (var i in intCollection)
            {
                Console.WriteLine(i);
            }
        }
    }
}
