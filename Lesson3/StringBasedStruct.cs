using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    public struct StringBasedStruct
    {
        public string Text;
       
        public StringBasedStruct(string text)
        {
            Text = text;
        }

        public CharBasedStruct GetIstanceOfCharBasedStruct(int index)
        {
            char symb = Text[index];
            CharBasedStruct charBasedStruct = new CharBasedStruct(symb);
            return charBasedStruct;
        }

    }
}
