using System;
using System.Collections.Generic;
using System.Text;

namespace _10._09._2019
{
    enum Product_type { electronics=0,food,medical,clothes, sport}
    struct Product_info
    {
        public string name;
        public Nullable< Product_type> type;
        public decimal price;
        public readonly DateTime data;
        public readonly int key;
        Product_info(int key)
        {
            data = DateTime.Now;
            this.name = "";
            this.type = null;
            this.price = 0;
            this.key = key;
        }
        void Set_all(out string name, out Product_type type, out decimal price)
        {
            this.name=Console.ReadLine();
            while (!(decimal.TryParse(Console.ReadLine(), out price)))
            {
                Console.WriteLine("Error!");
            }
            foreach (var p in Enum.GetNames(Product_type(type)))
            {
                
            }
            this.type = type;
        }
    }

    class Product
    {
        private Product_info product_info;
        static int count;
        static Product()
        {
            count = 0;
        }
        public Product()
        {
            product_info = new Product_info(count++);
        }
    }
}
