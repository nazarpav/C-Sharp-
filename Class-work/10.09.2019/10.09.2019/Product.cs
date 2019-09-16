using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    enum ProductType : byte
    {
        Electricity = 1,
        Food,
        Medical,
        Sport,
        Clothes
    }

    struct ProductInfo
    {
        // public fields 
        public readonly int code;
        public string name;
        public readonly DateTime date;
        public ProductType type;
        public decimal price;

        public ProductInfo(int code, string name, ProductType type, decimal price)
        {
            this.date = DateTime.Now; //  get currect date
            this.name = name;
            this.type = type;
            this.code = code;
            this.price = price;
        }
    }

    class Product
    {
       // private ProductInfo info;
        //private static int count;
        //private uint amount;

        public static int Count
        {
            private set;
            get;            
        }
        public ProductInfo Info
        {
            get;
        }
        public uint Amount
        {
            get;
        }

        // static ctor for initialize only static fields or properties
        static Product()
        {
            Count = 0;
        }

        public Product()
        {            
            GetDataFromKeyboard(out string name, out decimal price, out uint amount, out ProductType type);
            // it`s the same:
            //string name;
            //decimal price;
            //uint amount;
            //ProductType type;
            //GetDataFromKeyboard(out name, out price, out amount, out type);

            Info = new ProductInfo(1000 + Count, name, type, price);        
            ++Count;    // increase count of product
        }
        ~Product()
        {
            --Count;    // decrease count of product
        }

        public void GetDataFromKeyboard(out string name, out decimal price, out uint amount, out ProductType type)
        {
            Console.WriteLine("\tProduct types");
            foreach (var item in Enum.GetValues(typeof(ProductType))) // show all product type names
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\tSelect type: ");
            // TryParse will return true if the input value is correct and set it to the out parameter
            // If input`s incorrect, TryParse will return false and set default value
            while (!ProductType.TryParse(Console.ReadLine(), out type)) 
            {
                Console.WriteLine("Incorrect type! Please check your input and try again...");
            }

            Console.WriteLine("\tInput name: ");
            name = Console.ReadLine();

            Console.WriteLine("\tInput price: ");
            while (!decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Incorrect price, it`s must be a number! Please try again...");
            }

            Console.WriteLine("\tInput amount of product: ");
            while (!uint.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Incorrect amount! Please try again...");
            }
        }

        public void Show()
        {
            Console.WriteLine($"Code: {Info.code}\n" +
                $"Name: {Info.name}\n" +
                $"Date: {Info.date.ToShortDateString()}\n" +
                $"Type: {Info.type}\n" +
                $"Price: {Info.price}\n" +
                $"Amount: {Amount}\n");
        }
    }
}