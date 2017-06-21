namespace _02.KnightsOfHonor
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            Action<string> print = name => Console.WriteLine("Sir " + name);

            Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);
        }
    }
}
