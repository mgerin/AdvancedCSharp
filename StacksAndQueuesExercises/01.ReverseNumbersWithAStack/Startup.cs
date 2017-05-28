using System;
using System.Collections.Generic;

namespace _01.ReverseNumbersWithAStack
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<int>();

            foreach (var ch in input)
            {
                stack.Push(int.Parse(ch));
            }

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
