using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class PrivateListener
    {
        public PrivateListener(Invoker invoker)
        {
            invoker.SomethingHappened += PrivateListenerMethod;
        }

        private void PrivateListenerMethod(object sender, EventArgs e)
        {
            Console.WriteLine("This is a private method");
        }
    }
}
