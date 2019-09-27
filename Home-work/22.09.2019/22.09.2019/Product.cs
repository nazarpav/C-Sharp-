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
        private readonly int code1;
        private string name;
        private readonly DateTime date;
        private ProductType type;
        private decimal price;

        public int Code
        {
            get
            {
                return code1;
            }
        }

        internal ProductType Type { get => type; set => type = value; }
        public decimal Price { get => price; set => price = value; }

        public DateTime Date => date;

        public string Name { get => name; set => name = value; }

        public ProductInfo(int code, string name, ProductType type, decimal price)
        {
            this.date = DateTime.Now; //  get currect date
            this.name = name;
            this.type = type;
            this.code1 = code;
            this.price = price;
        }
    }

    class Product
    {
     
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
        public int Price
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
            Console.WriteLine($"Code: {Info.Code}\n" +
                $"Name: {Info.Name}\n" +
                $"Date: {Info.Date.ToShortDateString()}\n" +
                $"Type: {Info.Type}\n" +
                $"Price: {Info.Price}\n" +
                $"Amount: {Amount}\n");
        }
    }
}