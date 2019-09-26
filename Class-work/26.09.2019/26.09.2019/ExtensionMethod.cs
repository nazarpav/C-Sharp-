using System;
using System.Collections.Generic;
using System.Text;

namespace _26._09._2019
{
    static class ExtensionMethod
    {
        static public int CounterWord (this string str)
        {
            int counter=0;
            string buf = "";
            foreach (var n in str)
            {
                if (n != ' ' && n != '.' && n != ','&& n !=')' && n != '(' && n != '-' && n != '?' && n != '!' && n != '\"' && n != '`' && n != ';' && n != ':')
                    buf += n;
                else if (buf.Length > 0)
                {
                    counter++;
                    buf = "";
                }
            }
             if (buf.Length > 0)
            {
                counter++;
                buf = "";
            }
            return counter;
        }
    }
}
