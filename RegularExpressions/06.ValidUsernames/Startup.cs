namespace _06.ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"^[\w\d-]{3,16}$");

            while (input != "END")
            {
                MatchCollection matches = regex.Matches(input);
                if (matches.Count > 0)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
