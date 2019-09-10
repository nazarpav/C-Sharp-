using System;
using System.Collections.Generic;
using System.Text;

namespace _10._09._2019
{
    class Provider
    {
        private string name;
        private string country;
        private short rating;
        private bool is_pay_VAT;
        public void  Show()
        {
            Console.WriteLine("Name: "+name+"Country: "+country+" Ranting> "+ new string('*', rating) + "\n"+ (is_pay_VAT ? "\nPay VAT" : "\nNo pay VAT"));
            
        }
        public void Set_info(string name, string country)
        {
            this.name = name;
            this.country = country;
            var rand = new Random();
            this.rating = (short)rand.Next(1, 5);
            is_pay_VAT = rating > 2;
        }
    }
}
