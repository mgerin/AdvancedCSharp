using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SetsOfElements
{
    class Startup
    {
        static void Main()
        {
            var setsLength = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(setsLength[0]);
            int m = int.Parse(setsLength[1]);
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (firstSet.Contains(number))
                {
                    secondSet.Add(number);
                }
            }

            foreach (var num in secondSet)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
