using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.HandsOfCards
{
    class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var handsOfCards = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                var name = input.Split(':').First();
                var tokens = input.Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                var hashOfCards = new HashSet<string>();
                for (int i = 1; i < tokens.Length; i++)
                {
                    hashOfCards.Add(tokens[i]);
                }

                if (!handsOfCards.ContainsKey(name))
                {
                    handsOfCards.Add(name, hashOfCards);
                }
                else
                {
                    foreach (var hashOfCard in hashOfCards)
                    {
                        handsOfCards[name].Add(hashOfCard);
                    }
                }

                input = Console.ReadLine();
            }

            //points

            foreach (var handsOfCard in handsOfCards)
            {
                var totalPoints = 0;
                foreach (var card in handsOfCard.Value)
                {
                    int point;
                    var value = card.Last().ToString();
                    var power = card.Substring(0, card.Length - 1);
                    if (!int.TryParse(power, out point))
                    {
                        switch (power)
                        {
                            case "J":
                                point = 11;
                                break;
                            case "Q":
                                point = 12;
                                break;
                            case "K":
                                point = 13;
                                break;
                            case "A":
                                point = 14;
                                break;
                        }
                    }
                    switch (value)
                    {
                        case "S":
                            point *= 4;
                            break;
                        case "H":
                            point *= 3;
                            break;
                        case "D":
                            point *= 2;
                            break;
                        case "C":
                            point *= 1;
                            break;
                    }
                    totalPoints += point;
                }
                Console.WriteLine($"{handsOfCard.Key}: {totalPoints}");
            }
        }
    }
}
