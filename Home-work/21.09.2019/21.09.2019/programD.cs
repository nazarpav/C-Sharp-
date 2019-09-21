using System;
using System.Collections.Generic;
using System.Text;

namespace _21._09._2019
{
    class programD
    {
        private Worker[] arr;
        DateTime time;
        public programD()
        {
            arr = new Worker[5];
        }
        private DateTime EnterDate()
        {
            time = new DateTime();
            string b = "12.12.2211";
            foreach (var n in b)
            {
              //  b[]
            }
            return time;
        }
        
    
        public void EnterWorker()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Name: ");
                arr[i].Name=Console.ReadLine();
                Console.Write("Enter Surname:");
                arr[i].Surname = Console.ReadLine();
                Console.Write("Enter JobTitle:");
                arr[i].JobTitle = Console.ReadLine();
                Console.Write("Enter YearOfWork:");
                arr[i].YearOfWork = Console.ReadLine();
            }
        }
    }
}
