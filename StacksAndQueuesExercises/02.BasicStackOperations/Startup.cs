using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class Startup
    {
        static void Main()
        {
            var inputArgs = Console.ReadLine().Split(' ');
            int size = int.Parse(inputArgs[0]);
            int pop = int.Parse(inputArgs[1]);
            int pattern = int.Parse(inputArgs[2]);
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var stack = new Stack<int>();

            for (int i = 0; i < size; i++)
            {
                stack.Push(int.Parse(input[i])); 
            }

            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(pattern))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
