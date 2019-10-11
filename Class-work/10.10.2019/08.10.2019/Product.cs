using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _08._10._2019
{
    class Product
    {
        [Required(ErrorMessage = "Name not setted")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Illegal length")]
        [RegularExpression("^A-Z", ErrorMessage = "Illegal length")]
        private string _name;
        [Required(ErrorMessage = "price not set")]
        [Range(1, int.MaxValue, ErrorMessage = "Ivalid price")]
        private decimal _price;

        [Required(ErrorMessage = "Date not set")]
        [Range(typeof(DateTime), "1950.1.1", "2019.10.10")]
        private DateTime _dateProd;

        [Required(ErrorMessage = "Country not setted")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Illegal length")]
        private string _countryProd;
        [Required(ErrorMessage = "Country not setted")]
        [Range(1000, 9999, ErrorMessage = "Ivalid price")]
        private readonly int _CategoryId;

        [Required(ErrorMessage = "Country not setted")]
        [Range(1000, 9999, ErrorMessage = "Ivalid price")]
        private Nullable<int> sale;

        public string Name { get => _name; set => _name = value; }
        public decimal Price { get => _price; set => _price = value; }
        public DateTime DateProd { get => _dateProd; set => _dateProd = value; }
        public string CountryProd { get => _countryProd; set => _countryProd = value; }
        public int CategoryId => _CategoryId;

        public int? Sale { get => sale; set => sale = value; }

        public Product(string _name, decimal _price, DateTime _dateProd, string _countryProd, int _CategoryId, int sale)
        {
            this._name = _name;
            this._price = _price;
            this._dateProd = _dateProd;
            this._countryProd = _countryProd;
            this._CategoryId = _CategoryId;
            this.sale = sale;
        }
        public override string ToString()
        {
            return ("\nName=> "+_name+"\nPrice=> "+_price+"\nDate=> "+_dateProd.ToShortDateString()+"\nCountry Prod=> "+ _countryProd + "\nID=> "+ _CategoryId);
        }
    }
}
