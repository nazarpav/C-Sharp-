using System;
using System.Collections.Generic;
using System.Text;

namespace _21._09._2019
{
    struct Worker
    {
        private string name;
        private string surname;
        private string jobTitle;
        private DateTime yearOfWork;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public DateTime YearOfWork { get => yearOfWork; set => yearOfWork = value; }
    }
}
