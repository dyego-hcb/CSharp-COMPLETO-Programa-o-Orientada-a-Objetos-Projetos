using System;

namespace Course
{
    class PrintServiceString
    {
        private string[] _values = new string[10];
        private int _count = 0;

        public void AddValue(string value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full !");
            }

            _values[_count] = value;
            _count++;
        }

        public string Frist()
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
