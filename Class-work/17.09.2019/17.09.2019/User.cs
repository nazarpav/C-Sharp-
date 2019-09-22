using System;
using System.Collections.Generic;
using System.Text;

namespace _17._09._2019
{
    class User
    {
        static short counterId;
        private short id;
        private string _name;
        private string _login;
        private string _password;

        public User()
        {
            id = counterId++;
          
            _name = "None";
            _login = "None";
            _password = "Password";
        }
        public string Name { get => _name; set => _name = value; }
        public short Id { get => id;}
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }

        public override string ToString()
        {
            return "Name: "+Name+"| Id: "+Id ;    
        }
    }
}
