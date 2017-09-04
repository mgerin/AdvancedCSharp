namespace _03.GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var safeItems = new Dictionary<string, Dictionary<string, long>>
                                {
                                    ["Gold"] = new Dictionary<string, long>(),
                                    ["Gem"] = new Dictionary<string, long>(),
                                    ["Cash"] = new Dictionary<string, long>()
                                };

            var capacity = long.Parse(Console.ReadLine());
            var items = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            long currentQuantity = 0;

            for (int i = 0; i < items.Count; i += 2)
            {
                var name = items[i];
                var amount = long.Parse(items[i + 1]);

                if (currentQuantity + amount > capacity)
                {
                    continue;
                }

                if (name.Equals("Gold", StringComparison.InvariantCultureIgnoreCase))
                {
                    if (!safeItems["Gold"].ContainsKey("Gold"))
                    {
                        safeItems["Gold"]["Gold"] = 0;
                    }

                    safeItems["Gold"]["Gold"] += amount;
                    currentQuantity += amount;
                }
                else if (name.Length == 3)
                {
                    var cashAmount = safeItems["Cash"].Sum(c => c.Value);
                    var gemAmount = safeItems["Gem"].Sum(g => g.Value);

                    if (cashAmount + amount <= gemAmount)
                    {
                        if (!safeItems["Cash"].ContainsKey(name))
                        {
                            safeItems["Cash"][name] = 0;
                        }

                        safeItems["Cash"][name] += amount;
                        currentQuantity += amount;
                    }
                }
                else if (name.Length >= 4 && name.EndsWith("Gem", StringComparison.InvariantCultureIgnoreCase))
                {
                    var goldAmount = safeItems["Gold"].Sum(g => g.Value);
                    var gemAmount = safeItems["Gem"].Sum(g => g.Value);

                    if (gemAmount + amount <= goldAmount)
                    {
                        if (!safeItems["Gem"].ContainsKey(name))
                        {
                            safeItems["Gem"][name] = 0;
                        }

                        safeItems["Gem"][name] += amount;
                        currentQuantity += amount;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();

            if (safeItems["Gold"].Count > 0)
            {
                sb.AppendLine($"<Gold> ${safeItems["Gold"]["Gold"]}");
                sb.AppendLine($"##Gold - {safeItems["Gold"]["Gold"]}");
            }

            if (safeItems["Gem"].Count > 0)
            {
                var totalGemAmount = safeItems["Gem"].Sum(g => g.Value);
                sb.AppendLine($"<Gem> ${totalGemAmount}");

                foreach (var item in safeItems["Gem"].OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    sb.AppendLine($"##{item.Key} - {item.Value}");
                }
            }

            if (safeItems["Cash"].Count > 0)
            {
                var totalCashAmount = safeItems["Cash"].Sum(c => c.Value);
                sb.AppendLine($"<Cash> ${totalCashAmount}");

                foreach (var item in safeItems["Cash"].OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    sb.AppendLine($"##{item.Key} - {item.Value}");
                }

            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
