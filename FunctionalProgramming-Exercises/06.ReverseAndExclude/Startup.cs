namespace _06.ReverseAndExclude
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var divisor = int.Parse(Console.ReadLine());

            Predicate<int> divisibPredicate = num => num % divisor != 0;

            Console.WriteLine(string.Join(" ", numbers.Reverse().Where(num => divisibPredicate(num))));
        }
    }
}