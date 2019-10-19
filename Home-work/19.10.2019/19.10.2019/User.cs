using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _19._10._2019
{
    [Serializable]
    class User
    {
        public static int IdCount;
        public int Id { get; set; }
        [Required(ErrorMessage = "Not setted")]
        [RegularExpression(@"[a-z,A-Z]*", ErrorMessage = "Only a-z A-Z")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Not setted")]
        [RegularExpression(@"[a-z,A-Z]{8,}", ErrorMessage = "Only a-z A-Z")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Not setted")]
        [RegularExpression(@"[a-z,A-Z]{8,}", ErrorMessage = "Only a-z A-Z")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Not setted")]
        [EmailAddress]
        public string E_mail { get; set; }
        [Required(ErrorMessage = "Not setted")]
        [CreditCard]
        public string CreditCard { get; set; }
        [Required(ErrorMessage = "Not setted")]
        [RegularExpression(@"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$", ErrorMessage = "Phone format +xxxx-xxx-xxxx")]
        public string Phone { get; set ; }
        public User (string Login, string Password, string ConfirmPassword, string E_mail, string CreditCard, string Phone)
        {
            this.Login = Login;
            this.Password = Password;
            this.ConfirmPassword = ConfirmPassword;
            this.E_mail = E_mail;
            this.CreditCard = CreditCard;
            this.Phone = Phone;
            this.Id = IdCount++;
        }
        public void Swap(User user)
        {
            this.Login = user.Login;
            this.Password = user.Password;
            this.ConfirmPassword = user.ConfirmPassword;
            this.E_mail = user.E_mail;
            this.CreditCard = user.CreditCard;
            this.Phone = user.Phone;
            this.Id = user.Id;
        }
        public override string ToString()
        {
            return "ID=>>> "+Id+"\nLogin=> " + Login + "\nPasswprd=> " + Password + "\nE_mail" + E_mail + "\nCredit Card=> " + CreditCard + "\nPhone=> " + Phone;
        }
        public User()
        {
            this.Id = IdCount++;
        }
        ~User()
        {
            IdCount--;
        }
        static User()
        {
            IdCount = 1000;
        }
    }
}
