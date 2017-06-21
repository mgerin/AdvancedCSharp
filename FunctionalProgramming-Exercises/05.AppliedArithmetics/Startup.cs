namespace _05.AppliedArithmetics
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            // read commands and apply logic
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var command = input;
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(n => n + 1);
                        break;
                    case "multiply":
                        numbers = numbers.Select(n => n * 2);
                        break;
                    case "subtract":
                        numbers = numbers.Select(n => n - 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
            }
        }
    }
}