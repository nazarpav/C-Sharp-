using System;
using System.Collections.Generic;
using System.Text;

namespace _03._10._2019
{
    class PhoneBook
    {
        Dictionary<string,string> _PhoneBook;
        public PhoneBook()
        {
            _PhoneBook = new Dictionary<string, string>(); 
        }
        public void AddTelnum(string num,string val)
        {
            if (num.Length < 9)throw new Exception("Eeeeee  you need entered 9 num into telnum");
            _PhoneBook.Add(num, val);
        }
        public void GetValForTelNum(string TelNum)
        {
            if (TelNum.Length < 9) throw new Exception("Eeeeee  you need entered 9 num into telnum");
        }
        public override string ToString()
        {
            return _PhoneBook.ToString();
        }
    }
}
