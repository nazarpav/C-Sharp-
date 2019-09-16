using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Provider
    {
        // private fields
        private string name;
        private string country;
        private short raiting;
        private bool isPayVAT;

        // public properties for getting and setting (get, set)
        public string Name
        {
            get
            {
                if(char.IsLower(name[0]))
                {
                    name=char.ToUpper(name[0]) + name.Substring(1, name.Length - 1);
                }
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                   name = "no name";
                }
                else
                    name = value;
            }
        }
        public string Country
        {
            get { return country; }            
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    country = "no country";
                    return;
                }
                else
                    name = value;
            }
        }
        public short Raiting
        {
            get { return raiting; }            
            set
            {
                if (value > 5 || value < 0)
                {
                    raiting = 0;
                    return;
                }
                if (value > 2)
                    IsPayVAT=true;
            }
        }
        public bool IsPayVAT
        {
            get { return isPayVAT; }
            private set { isPayVAT = value; }
        }

        // Constructor        
        public Provider(string name, string country)
        {
            this.Name = name;
            this.Country = country;
            Raiting = (short)new Random().Next(6);  // randomize number from 0 to 5
            //isPayVAT = (raiting > 2);   // if raiting more than 2, provider paying VAT
        }
        public void Show()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Country: {Country}\n" +
                $"Raiting: {(Raiting > 0 ? new string('*', Raiting) : "No raiting")}\n" + // if there`s raiting, create string with ctor
                $"{(isPayVAT ? "Pay VAT" : "Not pay VAT")}\n"); 
        }
    }
}
