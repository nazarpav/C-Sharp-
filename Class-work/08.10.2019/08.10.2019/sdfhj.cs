using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using System.ComponentModel.Design.Serialization;

namespace _08._10._2019
{
    class qwerty
    {
        [Required]
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
                products.Add(new Product("Prod" + rnd.Next(0, 10), (decimal)(rnd.Next(150, 1500) * MathF.PI), new DateTime(rnd.Next(2015, 2019), rnd.Next(1, 12), rnd.Next(1, 28)), "Country" + rnd.Next(0, 5), rnd.Next(0, 5)));
            }
            foreach (var i in products)
            {
                Console.WriteLine(i);
            }
        }
        

        public void  Linq()
        {
            //var namelist= from p in products///////////////first
            //where (p.Price >= 100 && p.Price <= 1000)
            //select p.Name;

            //var namelist = from p in products
            //               where (p.DateProd.Year >= DateTime.Now.Year-2&&p.CountryProd== "Country2")
            //               select p.Name;

            //string name = "Prod1";
            //var namelist = from p in products
            //               where (p.Name == name || p.Name.Contains(name))
            //               select p.Name;

            //var namelist = from p in products
            //               where (p.Price== products.Max(i => i.Price)||p.Price== products.Min(i => i.Price))
            //               select p.CategoryId;
            //Console.WriteLine();
            //foreach (var i in namelist)
            //{
            //    Console.WriteLine(category[i]);
            //}

            //var namelist = from p in products
            //               where (p.CountryProd == "Country1")
            //               select p.Price;
            //Console.WriteLine();
            //decimal buf = 0;
            //foreach (var i in namelist)
            //    buf += i;
            //Console.WriteLine(buf/ namelist.ToList().Count);

            //foreach (var i in products)
            //{
            //    Console.WriteLine(i + "\n"+ category[i.CategoryId].Name);
            //}

            //var namelist = from p in products
            //               where (category[p.CategoryId].Name == "Electronic")
            //               select p;
            //Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //foreach (var i in namelist)
            //    Console.WriteLine(i);


        }
    }
}
