using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public abstract class BaseValidator
    {
        public void PrintError(string error)
        {
          Console.WriteLine(error);
        }

        public virtual bool IsValidUserName(string userName)
        {
            if (userName == null)
            {
                PrintError("UserName cannot be null");
            }
            return userName.Length > 0;
        }


    }
}
