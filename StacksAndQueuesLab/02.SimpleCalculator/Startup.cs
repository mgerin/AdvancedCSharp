using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SimpleCalculator
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var arguments = input.Split(' ');
            var stack = new Stack<string>(arguments.Reverse());

            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                switch (op)
                {
                    case "+":
                        stack.Push((firstNumber + secondNumber).ToString());
                        break;
                    case "-":
                        stack.Push((firstNumber - secondNumber).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
