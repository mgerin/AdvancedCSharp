using System;
using System.Collections.Generic;

namespace _05.CalculateSequenceWithQueue
{
    class Startup
    {
        static void Main()
        {
            var number = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();

            queue.Enqueue(number);

            for (int i = 0; i < 50; i++)
            {
                long queueElement = queue.Dequeue();
                queue.Enqueue(queueElement + 1);
                queue.Enqueue(queueElement * 2 + 1);
                queue.Enqueue(queueElement + 2);

                Console.Write(queueElement + " ");
            }
            Console.WriteLine();
        }
    }
}
