﻿using System;
using System.Collections.Generic;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = 20;
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < nums)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
