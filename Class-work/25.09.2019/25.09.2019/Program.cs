using System;
using System.Collections.Generic;
using System.Text;

namespace _25._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<string, byte> textData = new Dictionary<string, byte>(1);
            string text = "Ось будинок, який побудував Джек. А це пшениця, яка в темній комірці зберігається у будинку, який побудував Джек. А це весела птиця-синиця, яка часто краде пшеницю, яка в темній комірці зберігається у будинку, який побудував Джек.";
            string buf="";
            foreach (var n in text)
            {
               if(n != ' '&& n != '.' && n != ',')
                    buf += n;
                else if(buf.Length>0 )
                {
                    if(textData.ContainsKey(buf))
                        textData[buf]++;
                    else
                        textData.Add(buf, 1);
                    buf = "";
                }
            }
            foreach (var n in textData)
            {
                Console.WriteLine("text: "+n.Key+" | Counter: "+ n.Value);
            }
            Console.ReadKey();
        }
    }
}
