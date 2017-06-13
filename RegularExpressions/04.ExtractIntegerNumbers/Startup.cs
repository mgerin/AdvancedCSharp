namespace _04.ExtractIntegerNumbers
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"[\d]+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
