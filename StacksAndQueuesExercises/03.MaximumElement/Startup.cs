﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class Startup
    {
        static void Main()
        {
            int queriesNumber = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            var maxNumbers = new Stack<int>();
            int maxValue = int.MinValue;

            for (int i = 0; i < queriesNumber; i++)
            {
                var query = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                if (query[0] == 1)
                {
                    numbers.Push(query[1]);
                    if (maxValue < query[1])
                    {
                        maxValue = query[1];
                        maxNumbers.Push(maxValue);
                    }
                }
                else if (query[0] == 2)
                {
                    if (numbers.Pop() == maxValue)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count != 0)
                        {
                            maxValue = maxNumbers.Peek();
                        }
                        else
                        {
                            maxValue = int.MinValue;
                        }
                    }
                }
                else if (query[0] == 3)
                {
                    Console.WriteLine(maxValue);
                }
            }
        }
    }
}
