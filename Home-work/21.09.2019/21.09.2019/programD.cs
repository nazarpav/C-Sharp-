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
            time = DateTime.Parse(Console.ReadLine());
            return time;
        }
        public string ReturnSurname(DateTime time)//вывод на экран фамилии работника, стаж работы которого превышает введенное значение
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (DateTime.Now.Ticks - arr[i].YearOfWork.Ticks < time.Ticks)
                {
                    return arr[i].Surname;
                }
            }
            throw new Exception("undefined");
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
                arr[i].YearOfWork = EnterDate();
            }
        }
    }
}
