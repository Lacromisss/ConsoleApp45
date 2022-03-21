using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp45
{
    internal class User:IAccount
    {
        public User(string Fullname,string eMail, string Passwd)
        {
            this.Email = eMail;
            this._Password = Passwd;
            this.FullName = Fullname;

        }
        public string FullName;
        public string Email;
        private string _Password;
        public string Passwordd
        {
            get => _Password;

            set
            {
                if (PasswordChecker(value))
                {
                    this._Password = value;
                }

            }
        }

        public bool PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            if (!string.IsNullOrWhiteSpace(password) && password.Length > 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                        hasDigit = true;
                    else if (char.IsLower(password[i]))
                        hasLower = true;
                    else if (char.IsUpper(password[i]))
                        hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                        return true;
                }
            }

            return false;
        }

        public string ShowInfo()
        {
            return $"Username: {this.FullName} Email: {this.Email} ";


        }
    }
}

