using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class AccountValidator : IAccountValidator
    {

        public bool IsValidConfirmPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        public bool IsValidPassword(string password)
        {
            if (password == null) return false;
            return password.Length >= 6 && password.Length <= 12;
        }

        public bool IsValidUserName(string userName)
        {
            if (userName == null) return false;
            return userName.Length > 0;
        }
    }
}
