using System;

namespace _19._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(210,60);
            Monitor obj=new Monitor(0,"kiiv");
            obj.SetIsON(true);
            try
            {
            obj.DrawMonitorsExtension();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
