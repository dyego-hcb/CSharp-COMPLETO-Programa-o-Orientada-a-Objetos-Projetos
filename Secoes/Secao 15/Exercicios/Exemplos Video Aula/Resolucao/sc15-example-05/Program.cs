using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client c = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client d = new Client { Name = "Dyego", Email = "dyego@gmail.com" };
            Console.WriteLine(c.Equals(d));
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
        }
    }
}