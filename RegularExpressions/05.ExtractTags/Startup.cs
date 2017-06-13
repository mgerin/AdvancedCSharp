namespace _05.ExtractTags
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"<.*?>");

            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }

                input = Console.ReadLine();
            }
        }
    }
}
