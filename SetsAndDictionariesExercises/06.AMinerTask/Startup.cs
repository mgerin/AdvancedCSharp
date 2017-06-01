using System;
using System.Collections.Generic;

namespace _06.AMinerTask
{
    class Startup
    {
        static void Main()
        {
            var mine = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (true)
            {
                var recource = input;
                if (input == "stop")
                {
                    break;
                }
                var quntity = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(recource))
                {
                    mine.Add(recource, quntity);
                }
                else
                {
                    mine[recource] += quntity;
                }
                input = Console.ReadLine();
            }

            foreach (var pair in mine)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
