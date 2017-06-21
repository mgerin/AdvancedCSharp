namespace _04.FindEvensOrOdds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            // bounderies
            var size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();
            var min = size.Min();
            var max = size.Max();

            //options
            var option = Console.ReadLine();
            var numbers = new List<int>();

            //list filling
            for (int i = min; i <= max; i++)
            {
                numbers.Add(i);
            }

            //predicates
            Predicate<int> even = n => n % 2 == 0;
            Predicate<int> odd = n => n % 2 != 0;

            //output
            if (option.ToLower() == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.FindAll(even)));
            }
            else if (option.ToLower() == "odd")
            {
                Console.WriteLine(string.Join(" ", numbers.FindAll(odd)));
            }
        }
    }
}