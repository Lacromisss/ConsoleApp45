using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp45
{
    internal interface IAccount
    {
        public bool PasswordChecker(string a);
        public string ShowInfo();
    }
}
