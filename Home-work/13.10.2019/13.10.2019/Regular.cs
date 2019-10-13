using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _13._10._2019
{
    class Regular
    {
        public void Task1()
        {
            string str = System.IO.File.ReadAllText("Task1.txt");
            Regex regex = new Regex(@"\S*\w*\S*");
            MatchCollection matches = regex.Matches(str);
            str = "";
            foreach (Match i in matches)
            {
                if (string.IsNullOrWhiteSpace(i.Value)) continue;
                str += i.Value.ToCharArray()[0] = i.Value.ToString().ToUpper()[0] ;
                str += '.';
            }
            System.IO.File.WriteAllText("Task1.txt", str);
        }
    }
}
