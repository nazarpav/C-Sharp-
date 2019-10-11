using System;
using System.Collections.Generic;
using System.Text;

namespace _03._10._2019
{
    class ListString
    {
        Random rand = new Random();
        List<string> list= new List<string>();
        public void Start()
        {
            for (int i = 0; i < 40; i++)
            {
                list.Add("");
                for (int j = 0; j < rand.Next(4,13); j++)
                list[i]+= Convert.ToChar(rand.Next(65, 90));
            }
            int max = -1;
            foreach (var i in list)
                if (i.Length > max) max = i.Length;
            List<string> listbuf = new List<string>();
            foreach (var i in list)
                if (i.Length == max) listbuf.Add(i);
            listbuf.Sort();
            Console.WriteLine(listbuf[0]+"<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Task 2");
        }
    }
}
