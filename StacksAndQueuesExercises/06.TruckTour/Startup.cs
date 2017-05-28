using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<List<int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                queue.Enqueue(input);
            }

            var canItStart = false;
            for (int i = 0; i < n; i++)
            {
                var fuel = 0;

                foreach (var q in queue)
                {
                    fuel += q[0] - q[1];
                    if (fuel < 0)
                    {
                        canItStart = false;
                        break;
                    }
                    canItStart = true;
                }

                if (canItStart)
                {
                    Console.WriteLine(i);
                    break;
                }
                var reminder = queue.Dequeue();
                queue.Enqueue(reminder);
            }
        }
    }
}
