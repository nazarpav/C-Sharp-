using System;

namespace _17._09._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList obj=new UserList();
            obj.AddUser();
            Console.WriteLine(obj[0].ToString());
        }
    }
}
