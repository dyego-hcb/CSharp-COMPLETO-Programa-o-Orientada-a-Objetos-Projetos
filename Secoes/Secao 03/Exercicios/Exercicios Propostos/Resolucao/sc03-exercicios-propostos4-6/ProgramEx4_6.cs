﻿using System;

namespace MyApp {
    class ProgramEx4_6 {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
