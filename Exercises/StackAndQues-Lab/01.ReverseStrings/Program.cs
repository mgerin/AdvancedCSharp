namespace _01.ReverseStrings
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (char ch in input)
            {
                stack.Push(ch);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}
