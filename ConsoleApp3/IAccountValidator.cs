using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IAccountValidator
    {
        bool IsValidPassword(string password);
        bool IsValidConfirmPassword(string password, string confirmPassword);
        bool IsValidUserName(string userName);
    }
}
