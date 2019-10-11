using System;
using System.Collections.Generic;
using System.Text;

namespace _09._10._2019
{
    [Serializable]
    class User
    {
        private string _name;
        private string _login;
        private string _password;
        private string _confirmedPassword;
        private string _email;
        private string _phone;
        private int _age;

        public string Name { get => _name; set => _name = value; }
        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }
        public string ConfirmedPassword { get => _confirmedPassword; set => _confirmedPassword = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public int Age { get => _age; set => _age = value; }
    }
}
