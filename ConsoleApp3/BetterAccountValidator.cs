using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class BetterAccountValidator : IAccountValidator
    {
        public bool IsValidConfirmPassword(string password, string confirmPassword)
        {
            throw new NotImplementedException();
        }

        public bool IsValidPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool IsValidUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
