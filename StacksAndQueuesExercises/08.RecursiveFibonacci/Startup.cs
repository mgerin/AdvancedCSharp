﻿using System;

namespace _08.RecursiveFibonacci
{
    class Startup
    {
        private static long[] fibNumbers;
        static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());
            fibNumbers = new long[nthNumber];

            var result = GetFibonacci(nthNumber);
            Console.WriteLine(result);
        }

        private static long GetFibonacci(int nthNumber)
        {
            if (nthNumber <= 2)
            {
                return 1;
            }
            if (fibNumbers[nthNumber - 1] != 0)
            {
                return fibNumbers[nthNumber - 1];
            }
            return fibNumbers[nthNumber - 1] = GetFibonacci(nthNumber - 1) + GetFibonacci(nthNumber - 2);
        }
    }
}
