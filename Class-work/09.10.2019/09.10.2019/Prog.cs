using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _09._10._2019
{ 
    class Prog
    {
    public void Input(ref User user )
    {
        Console.WriteLine("Enter name");
        user.Name = Console.ReadLine();
        Console.WriteLine("Enter login");
        user.Login = Console.ReadLine();
        Console.WriteLine("Enter password");
        user.Password = Console.ReadLine();
        Console.WriteLine("Enter Confirmed password");
        user.ConfirmedPassword = Console.ReadLine();
        Console.WriteLine("Enter email");
        user.Email = Console.ReadLine();
        Console.WriteLine("Enter phone");
        user.Phone = Console.ReadLine();
        Console.WriteLine("Enter age");
        int.TryParse(Console.ReadLine(), out int age);
        user.Age = age;

    }
    }
}
