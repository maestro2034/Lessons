using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public class CoolAccountValidator : BaseValidator
    {
        public override bool IsValidUserName(string userName)
        {
            if (userName.StartsWith('A')) return true;
            PrintError("UserName must start with A");
            return false;
        }
    }
}
