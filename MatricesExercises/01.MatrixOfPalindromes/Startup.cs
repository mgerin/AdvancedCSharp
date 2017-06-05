using System;
using System.Linq;

namespace _01.MatrixOfPalindromes
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var matrix = new string[input[0]][];
            var abc = new char[] {'a', 'a', 'a'};

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = new string[input[1]];
                for (int coIndex = 0; coIndex < matrix[rowIndex].Length; coIndex++)
                {
                    matrix[rowIndex][coIndex] = new string(abc);
                    abc[1]++;
                }
                abc[1] = abc[0];
                abc[0]++;
                abc[1]++;
                abc[2]++;
            }

            foreach (var m in matrix)
            {
                Console.WriteLine(string.Join(" ", m));
            }
        }
    }
}
