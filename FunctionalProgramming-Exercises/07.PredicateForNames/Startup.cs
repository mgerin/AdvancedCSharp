namespace _07.PredicateForNames
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            Predicate<string> lengthPredicate = str => str.Length <= length;

            Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => lengthPredicate(w))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
