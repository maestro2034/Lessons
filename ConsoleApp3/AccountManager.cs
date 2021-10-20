using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class AccountManager : IAccountManager
    {
        private IAccountValidator _validator;

        public AccountManager(IAccountValidator validator)
        {
            _validator = validator;
        }
        public void IsValidAccount(Account account)
        {
            Console.WriteLine(_validator.IsValidPassword(account.ConfirmPassword) &&
                 _validator.IsValidUserName(account.UserName) &&
                 _validator.IsValidConfirmPassword(account.Password, account.ConfirmPassword)); 
        }

        public void Save(Account account)
        {
            Console.WriteLine($"Save {account.UserName} to DB");
        }
    }
}
