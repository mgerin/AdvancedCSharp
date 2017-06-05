using System;
using System.Linq;

namespace _02.DiagonalDifference
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            var firstDiagonal = 0;
            var secondDiagonal = 0;

            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                firstDiagonal += matrix[rowIndex][rowIndex];
                secondDiagonal += matrix[rowIndex][n - rowIndex - 1];
            }

            Console.WriteLine(Math.Abs(firstDiagonal - secondDiagonal));
        }
    }
}
