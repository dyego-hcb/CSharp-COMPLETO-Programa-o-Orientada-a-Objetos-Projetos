using System;
namespace Course {
    class Program {
        static void Main(string[] args) {
            //double x = null; // erro
            Nullable<double> x1 = null;
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);
            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");
            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

            double? x2 = null;
            double? x3 = 23;
            double y1= x2 ?? 5.0;
            double y2= x3 ?? 5.0;

            Console.WriteLine(x3);
            Console.WriteLine(y1);
            Console.WriteLine(y1);
        }
    }
}