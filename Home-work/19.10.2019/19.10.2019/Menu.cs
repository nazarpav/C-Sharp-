using System;
using System.Collections.Generic;
using System.Text;

namespace _19._10._2019
{
    class Menu
    {
        Dictionary<int,User> Userlist;
        public void Start()
        {
            Userlist = new Dictionary<int, User>();
            while (true)
            {
                int id = 0;
                Console.Clear();
                Console.WriteLine("1 - Create\n2 - Read\n3 - Update\n4 - Delete\n5 - Deserialization\n6 - Serialization\n\n 0 - Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        User newUser = new User();
                        while (true)
                        {
                                Console.Clear();
                                Console.WriteLine("Enter Login");
                                newUser.Login = Console.ReadLine();
                                Console.WriteLine("Enter Password");
                                newUser.Password = Console.ReadLine();
                                Console.WriteLine("Confirm Password");
                                newUser.ConfirmPassword = Console.ReadLine();
                                Console.WriteLine("Enter Email");
                                newUser.E_mail = Console.ReadLine();
                                Console.WriteLine("Enter Credit card");
                                newUser.CreditCard = Console.ReadLine();
                                Console.WriteLine("Enter Phone number");
                                newUser.Phone = Console.ReadLine();
                            try
                            {
                            }
                            catch
                            {
                                continue;
                            }
                            break;
                        }
                        Userlist.Add(newUser.Id, newUser);
                        break;
                    case "2":
                        id = 0;
                        Console.WriteLine("Enter Id");
                        while (!(int.TryParse(Console.ReadLine(), out id) && Userlist.ContainsKey(id)))
                            Console.WriteLine("Enter Id");
                        Console.WriteLine(Userlist[id]);
                        Console.ReadKey();

                        break;
                    case "3":
                        id = 0;
                        Console.WriteLine("Enter Id");
                        while (!(int.TryParse(Console.ReadLine(), out id) && Userlist.ContainsKey(id)))
                            Console.WriteLine("Enter Id");
                        Console.WriteLine("Enter Login");
                        Userlist[id].Login = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        Userlist[id].Password = Console.ReadLine();
                        Console.WriteLine("Confirm Password");
                        Userlist[id].ConfirmPassword = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        Userlist[id].E_mail = Console.ReadLine();
                        Console.WriteLine("Enter Credit card");
                        Userlist[id].CreditCard = Console.ReadLine();
                        Console.WriteLine("Enter Phine number");
                        Userlist[id].Phone = Console.ReadLine();
                        break;
                    case "4":
                        id = 0;
                        Console.WriteLine("Enter Id");
                        while (!(int.TryParse(Console.ReadLine(), out id) && Userlist.ContainsKey(id)))
                            Console.WriteLine("Enter Id");
                        Userlist.Remove(id);
                        Console.WriteLine("Success");
                        Console.ReadKey();

                        break;
                    case "0": return;
                }
            }
        }
    }
}
