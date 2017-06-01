using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CountSymbols
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var chars = new SortedDictionary<char, int>();
            int count = 1;

            for (int i = 0; i < input.Length; i++)
            {
                chars.Add(input[i], count);
            }
        }
    }
}
