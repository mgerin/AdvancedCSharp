using System;
using System.Collections.Generic;

namespace _02.SoftUniParty
{
    class Startup
    {
        static void Main()
        {
           var partyPeople = new SortedSet<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                partyPeople.Add(input);
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                if (partyPeople.Contains(input))
                {
                    partyPeople.Remove(input);
                }
            }

            Console.WriteLine(partyPeople.Count);
            foreach (var guest in partyPeople)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
