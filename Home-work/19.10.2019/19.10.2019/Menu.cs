using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _19._10._2019
{
    [Serializable]
    class Menu
    {
        Dictionary<int,User> Userlist;
        public void Start()
        {
            Userlist = new Dictionary<int, User>();
            bool isValid=false;
            while (true)
            {
                int id = 0;
                BinaryFormatter binFormat = new BinaryFormatter();
                Console.Clear();
                Console.WriteLine("1 - Create\n2 - Read\n3 - Update\n4 - Delete\n5 - Deserialization\n6 - Serialization\n\n 0 - Exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        User newUser = new User();
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Login");
                            string Login = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string Password = Console.ReadLine();
                            Console.WriteLine("Confirm Password");
                            string ConfirmPassword = Console.ReadLine();
                            Console.WriteLine("Enter Email");
                            string E_mail = Console.ReadLine();
                            Console.WriteLine("Enter Credit card");
                            string CreditCard = Console.ReadLine();
                            Console.WriteLine("Enter Phone number");
                            string Phone = Console.ReadLine();

                            newUser.Login = Login;
                            newUser.Password = Password;
                            newUser.ConfirmPassword = ConfirmPassword;
                            newUser.E_mail = E_mail;
                            newUser.CreditCard = CreditCard;
                            newUser.Phone = Phone;
                            var results = new List<ValidationResult>();
                            var context = new ValidationContext(newUser);
                            if (!(isValid = Validator.TryValidateObject(newUser, context, results, true)))
                            {
                                foreach (ValidationResult error in results)
                                {
                                    Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                                }
                            }

                        } while (!isValid);
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
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Enter Login");
                            string Login = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string Password = Console.ReadLine();
                            Console.WriteLine("Confirm Password");
                            string ConfirmPassword = Console.ReadLine();
                            Console.WriteLine("Enter Email");
                            string E_mail = Console.ReadLine();
                            Console.WriteLine("Enter Credit card");
                            string CreditCard = Console.ReadLine();
                            Console.WriteLine("Enter Phone number");
                            string Phone = Console.ReadLine();

                            Userlist[id].Login = Login;
                            Userlist[id].Password = Password;
                            Userlist[id].ConfirmPassword = ConfirmPassword;
                            Userlist[id].E_mail = E_mail;
                            Userlist[id].CreditCard = CreditCard;
                            Userlist[id].Phone = Phone;
                            var results = new List<ValidationResult>();
                            var context = new ValidationContext(Userlist[id]);
                            if (!(isValid = Validator.TryValidateObject(Userlist[id], context, results, true)))
                            {
                                foreach (ValidationResult error in results)
                                {
                                    Console.WriteLine(error.MemberNames.FirstOrDefault() + ": " + error.ErrorMessage);
                                }
                            }

                        } while (!isValid);
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
                    case "5":
                        try
                        {
                            using (Stream fStream = File.Create("test.bin"))
                            {
                                binFormat.Serialize(fStream, Userlist);
                            }
                            Console.WriteLine("BinarySerialize OK!\n");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        break;
                    case "6":
                        using (Stream fStream = File.OpenRead("test.bin"))
                        {
                            Userlist = (Dictionary<int, User>)binFormat.Deserialize(fStream);
                        }
                        break;
                    case "0": return;
                }
            }
        }
    }
}
