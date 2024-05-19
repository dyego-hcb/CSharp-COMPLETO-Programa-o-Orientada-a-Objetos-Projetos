using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = CalculatorBad.Sum(2, 3);
            int s2 = CalculatorBad.Sum(2, 3, 4);
            int s3 = CalculatorBad.Sum(2, 3, 4, 5);

            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
            System.Console.WriteLine(s3);

            int s4 = CalculatorGood.Sum(new int[] { 10, 20, 30, 40 });

            System.Console.WriteLine(s4);

            int s5 = CalculatorGood.Sum(10, 20, 30, 40);

            System.Console.WriteLine(s5);
        }
    }
}