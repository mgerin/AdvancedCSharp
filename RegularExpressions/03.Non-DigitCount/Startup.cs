namespace _03.Non_DigitCount
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"[^\d]";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
