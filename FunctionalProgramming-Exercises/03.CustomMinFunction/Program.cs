namespace _03.CustomMinFunction
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Func<int[], int> customMinFunc = nums => nums.Min();

            Console.WriteLine(customMinFunc(Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray()));
        }
    }
}
