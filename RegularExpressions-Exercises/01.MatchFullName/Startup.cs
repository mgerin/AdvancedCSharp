namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = String.Empty;
            Regex regex = new Regex("\\b([A-Z][a-z]+) ([A-Z][a-z]+)\\b");

            while ((input = Console.ReadLine()) != "end")
            {

                Console.WriteLine(regex.Match(input));
            }
        }
    }
}
