using System;
using System.Collections.Generic;
using System.Text;

namespace _08._10._2019
{
    class Category
    {
        private int _ID;
        private string _name;
        private string _description;
        public Category( int ID, string _name,string _description)
        {
            this._name = _name;
            this._ID = ID;
            this._description = _description;
        }
        public int ID => _ID;
        public string Name { get => _name;}
        public string Description { get => _description; set => _description = value; }





    }
}
