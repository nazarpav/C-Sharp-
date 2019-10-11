using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._10._2019
{
        delegate int T1();
        delegate void T2();
    class delegates
    {
        List<int> array = new List<int>();

        List<T2> T2A = new List<T2>();
        List<T1> T1A = new List<T1>();
        Random random = new Random();
        private void Start()
        {
            for (int i = 0; i < 20; i++)
            {
                array.Add(random.Next(-50, 50));
            }
        T1A.Add(T1_1);
        T1A.Add(T1_2);
        T1A.Add(T1_3);

        T2A.Add(T2_1);
        T2A.Add(T2_2);
        T2A.Add(T2_3);
        }
        public void Menu()
        {
            Start();
            int choise = 0;
            int choise2 = 0;
            int choise3 = 0;
            Console.WriteLine("1- Calculation\n2 - change array");
            while (!(int.TryParse(Console.ReadLine(), out choise)))
            { }
            while (choise == 1)
            {
                Console.WriteLine("1-Calculate quantity negative element\n2- Sum all elemets\n3- Count up simple number");
                while (!(int.TryParse(Console.ReadLine(), out choise2)))
                { }
                Console.WriteLine("===================================");
                Console.WriteLine(T1A[choise2-1].Invoke());
                Console.WriteLine("===================================");
                break;
            }
            while (choise == 2)
            {
                Console.WriteLine("1- Change all elemet on negative\n2- Sort array\n3- Move pair eleme to  begin array");
                while (!(int.TryParse(Console.ReadLine(), out choise3)))
                { }
                T2A[choise3-1].Invoke();
                break;
            }
            while (choise != 2 && choise != 1)
            {

                throw new Exception("invalid choise");
                break;
            }
            foreach (var i in array)
            {
                Console.WriteLine(i+" ");
            }
        }
        private int T1_1()
        {
            int counter = 0;
            foreach (var i in array)
            {
                while(i<0)
                {
                    counter++;
                    break;
                }
            }
            return counter;
        }
        private int T1_2()
        {
            int counter = 0;
            foreach (var i in array)
            {
                counter += i;
            }
            return counter;
        }
        private int T1_3()
        {
            int counter = 0;
            foreach (var i in array)
            {
                while (IsPrime(i))
                {
                    counter++;
                    break;
                }
            }
            return counter;
        }

        private void T2_1()
        {
            for (int i = 0; i < array.Count; i++)
            {
                while (array[i] < 0)
                {
                    array[i] = 0;
                    break;
                }
            }
        }
        private void T2_2()
        {
            array.Sort();
        }
        private void T2_3()
        {
            int temp=0;
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = i + 1; j < array.Count; j++)
                {
                    while (array[i]%2!=0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        break;
                    }
                }
            }
        }












        private bool IsPrime(int n)
        {
            while (n > 1)return Enumerable.Range(1, n).Where(x => n % x == 0).SequenceEqual(new[] { 1, n });
            return false;
        }
    }
}
