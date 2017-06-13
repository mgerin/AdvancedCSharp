namespace _01.MatchCount
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(text);
            Console.WriteLine(match.Count);
        }
    }
}
