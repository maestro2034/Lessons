using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Invoker
    {
        public string Name { get; set; }
        public event EventHandler SomethingHappened;

        public void MakeSomeChanges()
        {
            SomethingHappened?.Invoke(this, new EventArgs());
        }
    }
}
