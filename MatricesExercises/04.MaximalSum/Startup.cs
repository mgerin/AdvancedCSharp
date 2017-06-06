using System;
using System.Linq;

namespace _04.MaximalSum
{
    class Startup
    {
        static void Main()
        {
            var matrixSize = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var matrix = new int[matrixSize[0]][];
            var maxSum = int.MinValue;
            var maxPosition = new int[2];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }

            for (int rowIndex = 0; rowIndex < matrix.Length - 2; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length - 2; colIndex++)
                {
                    var sum = matrix[rowIndex][colIndex] + matrix[rowIndex][colIndex + 1] +
                              matrix[rowIndex][colIndex + 2] +
                              matrix[rowIndex + 1][colIndex] + matrix[rowIndex + 1][colIndex + 1] +
                              matrix[rowIndex + 1][colIndex + 2] + matrix[rowIndex + 2][colIndex] +
                              matrix[rowIndex + 2][colIndex + 1] + matrix[rowIndex + 2][colIndex + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxPosition[0] = rowIndex;
                        maxPosition[1] = colIndex;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = maxPosition[0]; i <= maxPosition[0] + 2; i++)
            {
                for (int j = maxPosition[1]; j <= maxPosition[1] + 2; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
