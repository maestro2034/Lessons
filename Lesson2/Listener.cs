using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Listener
    {
        public void Listen(object sender, EventArgs e)
        {
            Console.WriteLine("Some changes happened in different place");
        }
    }
}
