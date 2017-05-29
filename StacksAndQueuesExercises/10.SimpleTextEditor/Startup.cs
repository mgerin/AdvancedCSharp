using System;
using System.Collections.Generic;

namespace _10.SimpleTextEditor
{
    class Startup
    {
       

        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();
            stack.Push(String.Empty);
            

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var cmd = int.Parse(input[0]);

                switch (cmd)
                {
                    case 1:
                        var text = input[1];
                        var update = stack.Peek() + text;
                        stack.Push(update);
                        break;
                    case 2:
                        var count = int.Parse(input[1]);
                        var updateNew = stack.Peek();
                        update = updateNew.Remove(updateNew.Length - count);
                        stack.Push(update);
                        break;
                    case 3:
                        var index = int.Parse(input[1]);
                        var lastUpdate = stack.Peek();
                        Console.WriteLine(lastUpdate[index - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        break;
                }
            }
        }
    }
}
