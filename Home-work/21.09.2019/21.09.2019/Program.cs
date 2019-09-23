using System;

namespace _21._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Calculator c=new Calculator();
            //c.Start();
            ///////////////////////////////////////////////////////////////////==================================================<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            //TASK 2
            DateTime time = new DateTime();
            programD obj = new programD();
            obj.EnterWorker();
            time= DateTime.Parse(Console.ReadLine());
            Console.WriteLine(obj.ReturnSurname(time));
        }
    }
}
