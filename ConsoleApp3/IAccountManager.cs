using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public interface IAccountManager
    {
        void Save(Account account);
        void IsValidAccount(Account account);
    }
}
