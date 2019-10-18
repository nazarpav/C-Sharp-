using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using System.ComponentModel.Design.Serialization;

namespace _08._10._2019
{
    class qwerty
    {
        private List<Category> category;
        private List<Product> products;
        Random rnd = new Random();
        public qwerty()
        {
           
            category = new List<Category>();
            products = new List<Product>();
            category.Add(new Category(0, "Electronic", "description" + rnd.Next(0, 10)));
            category.Add(new Category(1, "Health", "description" + rnd.Next(0, 10)));
            category.Add(new Category(2, "Books", "description" + rnd.Next(0, 10)));
            category.Add(new Category(3, "Home", "description" + rnd.Next(0, 10)));
            category.Add(new Category(4, "Sport", "description" + rnd.Next(0, 10)));
        }
        public void Start()
        {
            for (int i = 0; i < 30; i++)
            {
                products.Add(new Product("Prod" + rnd.Next(0, 10), (decimal)(rnd.Next(150, 1500) * MathF.PI), new DateTime(rnd.Next(2015, 2020), rnd.Next(1, 12), rnd.Next(1, 28)), "Country" + rnd.Next(0, 5), rnd.Next(0, 5)));
            }
            products.Add(new Product("Prod" + rnd.Next(0, 10), (decimal)(rnd.Next(150, 1500) * MathF.PI),DateTime.Now, "Country" + rnd.Next(0, 5), rnd.Next(0, 5)));
            foreach (var i in products)
            {
                Console.WriteLine(i);
            }
        }
        

        public void  Linq()
        {

            //Task1();
            //Task2("Country1");
            //Task3("Electronic");

            //       Country "Ukraine" = "Country1"
            Task4();
        }
        private void Task1()
        {
            var namelist = from p in products
                           where (p.DateProd.Year == DateTime.Now.Year)
                           select p;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (var i in namelist)
                Console.WriteLine(i);
        }
        private void Task2(string country)
        {
            var namelist = from p in products
                           where (p.CountryProd==country)
                           select p;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Count Prod in "+country+" = "+namelist.Count());
        }
        private void Task3(string Category)
        {
            var namelist = from p in products
                           where (category[p.CategoryId].Name == Category)
                           select p.Price;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Max Price Prod in " + Category + " = " + namelist.ToList().Max());
            Console.WriteLine("Min Price Prod in " + Category + " = " + namelist.ToList().Min());
        }
        private void Task4()
        {
            //       Country "Ukraine" = "Country1"

            var namelist = from p in products
                           where (p.CountryProd == "Country1")
                           select category[p.CategoryId];
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            namelist = namelist.GroupBy(x => x.Name).Select(y => y.FirstOrDefault());
            foreach (var i in namelist)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
