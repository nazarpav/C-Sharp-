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
        public void Task5()
        {
            Regex regexEmail = new Regex(@"(\w|\d|\.|_|\-){4,18}@(\w|\d){1,20}.(\w|\d){1,20}");
            Regex regexPassword = new Regex(@"([A-Z]|[a-z]|\d|(\-|_)){6,}");
            MatchCollection matches = regexEmail.Matches(Console.ReadLine());
            MatchCollection matches2 = regexPassword.Matches(Console.ReadLine());
            foreach (var i in matches)
            {
                 Console.WriteLine("Email => "+ i);
            }
            foreach (var i in matches2)
            {
                Console.WriteLine("Password => " + i);
            }
        }
        public void Task6()
        {
            string str = System.IO.File.ReadAllText("Task6.txt");
            Regex regex = new Regex(@"\d{0,4}\/\d{1,}\/\d{1,} \d{1,}:\d{1,}(:\d+)?");
            MatchCollection matches = regex.Matches(str);
            foreach (var i in matches)
            {
                Console.WriteLine("date => " + i);
            }
        }
        public void Task7()
        {
            string str = System.IO.File.ReadAllText("Task7.txt");
            Regex regex = new Regex(@"\d{9,9}");
            MatchCollection matches = regex.Matches(str);

            foreach (Match i in matches)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                System.IO.File.AppendAllText("Task7out.txt", "+38(0" + i.Value[0] + i.Value[1] + ") " + i.Value[2] + i.Value[3] + i.Value[4] + "-" + i.Value[5] + i.Value[6] + "-" + i.Value[7] + i.Value[8]+ Environment.NewLine);
            }
        }
        public void Task8()
        {
            string str = System.IO.File.ReadAllText("Task8.txt");
            Regex regex1 = new Regex(@"\*\w*\*");
            Regex regex2 = new Regex(@"-\w*-");
            MatchCollection matches1 = regex1.Matches(str);

            foreach (Match i in matches1)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                str = regex1.Replace(str, i.Value.Trim('*').ToUpper(),1);
            }
            MatchCollection matches2 = regex2.Matches(str);
            foreach (Match i in matches2)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                str = regex2.Replace(str, i.Value.Trim('-').ToLower(), 1);
            }
            System.IO.File.WriteAllText("Task8out.txt", str);


        }
    }
}
