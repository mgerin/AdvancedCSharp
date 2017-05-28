using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BasicQueueOperations
{
    class Startup
    {
        static void Main()
        {
            var inputArgs = Console.ReadLine().Split(' ');
            int size = int.Parse(inputArgs[0]);
            int dequeue = int.Parse(inputArgs[1]);
            int pattern = int.Parse(inputArgs[2]);
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<int>();

            for (int i = 0; i < size; i++)
            {
                queue.Enqueue(int.Parse(input[i]));
            }

            for (int i = 0; i < dequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(pattern))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
