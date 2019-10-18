using System;
using System.Collections.Generic;
using System.Text;

namespace _08._10._2019
{
    class Product
    {
        private string _name;
        private decimal _price;
        private DateTime _dateProd;
        private string _countryProd;
        private readonly int _CategoryId;

        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public DateTime DateProd { get => _dateProd; set => _dateProd = value; }
        public string CountryProd { get => _countryProd; set => _countryProd = value; }
        public int CategoryId => _CategoryId;
        public Product(string _name, decimal _price, DateTime _dateProd, string _countryProd, int _CategoryId)
        {
            this._name = _name;
            this._price = _price;
            this._dateProd = _dateProd;
            this._countryProd = _countryProd;
            this._CategoryId = _CategoryId;
        }
        public override string ToString()
        {
            return ("\nName=> "+_name+"\nPrice=> "+_price+"\nDate=> "+_dateProd.ToShortDateString()+"\nCountry Prod=> "+ _countryProd + "\nID=> "+ _CategoryId);
        }
    }
}
