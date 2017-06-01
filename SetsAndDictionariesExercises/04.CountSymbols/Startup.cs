using System;
using System.Collections.Generic;

namespace _04.CountSymbols
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var chars = new SortedDictionary<char, int>();

            foreach (char c in input)
            {
                if (!chars.ContainsKey(c))
                {
                    chars.Add(c, 1);
                    continue;
                }
                chars[c]++;
            }
            foreach (var pair in chars)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
            
        }
    }
}
