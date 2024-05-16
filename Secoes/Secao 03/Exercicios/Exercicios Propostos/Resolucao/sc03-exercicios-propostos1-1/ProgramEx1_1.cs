using System;
using System.Globalization;

namespace MyApp {
    class ProgramEx1_1 {
        static void Main(string[] args) {
            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);

        }
    }
}