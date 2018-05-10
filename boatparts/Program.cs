using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

            int NrOfParts = tokens[0]; // p (parts in the boat)
            int days = tokens[1]; // n (number of days in boating season)

            // 1 < parts < days < 1000 (some boating seasons are long huh?)
            // every day a part is bought, but the number of distinct parts is at most P

            var partsReplaced = new HashSet<string>();

            // start day at 1 since we want to 1 index like humans do
            for (int day = 1; day <= days; day++)
            {
                var part = Console.ReadLine();
                partsReplaced.Add(part);

                if (partsReplaced.Count >= NrOfParts)
                {
                    Console.WriteLine(day);
                    return;
                }
            }

            if (partsReplaced.Count < NrOfParts)
            {
                Console.WriteLine("paradox avoided");
            }
        }
    }
}
