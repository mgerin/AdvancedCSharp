using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.UniqueUsernames
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var input = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                input.Add(Console.ReadLine());
            }

            foreach (var user in input)
            {
                Console.WriteLine(user);
            }
        }
    }
}
