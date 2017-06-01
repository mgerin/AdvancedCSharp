using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Periodic_Table
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var e in input)
                {
                    elements.Add(e);
                }
            }

            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
