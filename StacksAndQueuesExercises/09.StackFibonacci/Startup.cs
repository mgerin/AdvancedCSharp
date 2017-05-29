using System;
using System.Collections.Generic;

namespace _09.StackFibonacci
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();

            stack.Push(0);
            stack.Push(1);
            for (int i = 3; i <= 70; i++)
            {
                var firstNumber = stack.Pop();
                var secondNumber = stack.Peek();
                stack.Push(firstNumber);
                stack.Push(firstNumber + secondNumber);
            }
            for (int i = 1; i < 70 - n; i++)
            {
                stack.Pop();
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
