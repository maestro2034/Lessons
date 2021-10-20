using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public abstract class MyBase
    {
        protected int[] _arr;
        public int Size { get; set; }
        public MyBase(int size)
        {
            _arr = new int[size];
            Size = size;
        }
        public abstract void MyMethod();

        public int this[int k]
        {
            get => _arr[k];
            set => _arr[k] = value;
        }
    }
}
