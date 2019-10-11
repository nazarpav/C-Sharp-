using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _09._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Prog p = new Prog();
            p.Input(ref user);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("user.bin", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, user);
                Console.WriteLine("+");
            }
        }
    }
}
