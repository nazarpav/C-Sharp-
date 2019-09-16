using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product");
            // create product
            var prod = new Product(); 
            prod.Show();

            Console.WriteLine("Provider");
            // create provider
            var prov = new Provider("nnm","nn"); 
            prov.Show();
        }
    }
}
