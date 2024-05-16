using System;

namespace MyApp {
    class ProgramEx4_1 {
        static void Main(string[] args) {

            iint x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
