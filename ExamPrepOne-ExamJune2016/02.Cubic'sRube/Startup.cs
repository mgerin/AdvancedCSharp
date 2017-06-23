namespace _02.Cubic_sRube
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var dimensionSize = int.Parse(Console.ReadLine());
            var sumOfParticles = 0L;
            var changedCells = 0;
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Analyze")
            {
                var tokens = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (tokens.Take(3).Any(pt => pt < 0 || pt >= dimensionSize))
                {
                    continue;
                }

                if (tokens[3] != 0)
                {
                    sumOfParticles += tokens[3];
                    changedCells++;
                }
            }

            Console.WriteLine(sumOfParticles);
            Console.WriteLine(Math.Pow(dimensionSize, 3) - changedCells);
        }
    }
}