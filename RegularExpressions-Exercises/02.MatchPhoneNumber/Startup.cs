namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            const string pattern = "\\+359( |-)2\\1([0-9]{3})\\1([0-9]{4})\\b";
            Regex regex = new Regex(pattern);
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                foreach (Match match in regex.Matches(input))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
