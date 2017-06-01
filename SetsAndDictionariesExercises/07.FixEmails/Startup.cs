using System;
using System.Collections.Generic;

namespace _07.FixEmails
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var emails = new Dictionary<string, string>();

            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();
                if (!email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emails.Add(name, email);
                }
                input = Console.ReadLine();
            }

            foreach (var person in emails)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
