namespace _02.VowelCount
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            string pattern = "[AEIOUYaeiouy]";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);

            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
