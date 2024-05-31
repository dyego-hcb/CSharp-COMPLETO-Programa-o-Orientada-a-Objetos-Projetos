using System;

namespace Course
{
    class PrintService
    {
        private object[] _values = new object[10];
        private int _count = 0;

        public void AddValue(object value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full !");
            }

            _values[_count] = value;
            _count++;
        }

        public object Frist()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty !");
            }

            return _values[0];
        }

        public void Print()
        {
            System.Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                System.Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                System.Console.Write(_values[_count - 1]);
            }
            System.Console.WriteLine("]");
        }
    }
}
