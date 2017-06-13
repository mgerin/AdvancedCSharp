namespace _07.ValidTime
{
    using System;
    using System.Text.RegularExpressions;

    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"^([01][0-9]):([012345][0-9]):([012345][0-9]) [AP]M$");

            while (input != "END")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    if (IsValidTime(match))
                    {
                        Console.WriteLine("valid");
                    }
                    else
                    {
                        Console.WriteLine("invalid");
                    }
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }

        private static bool IsValidTime(Match clockMatch)
        {
            int hours = int.Parse(clockMatch.Groups[1].Value);
            int minutes = int.Parse(clockMatch.Groups[2].Value);
            int seconds = int.Parse(clockMatch.Groups[3].Value);
            if (hours >= 0 && hours <= 12)
            {
                if (minutes >= 0 && minutes < 60)
                {
                    if (seconds >= 0 && seconds < 60)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
