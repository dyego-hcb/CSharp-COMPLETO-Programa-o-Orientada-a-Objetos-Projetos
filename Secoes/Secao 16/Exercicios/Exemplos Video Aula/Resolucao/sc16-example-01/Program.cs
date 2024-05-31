using System;
using Course.Extensions;

namespace Course
{
    class Program
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}