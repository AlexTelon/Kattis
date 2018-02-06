using System;
using System.Collections.Generic;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var TopUniversities = new Dictionary<string, string>();

            var num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                var inputs = Console.ReadLine().Split();

                var university = inputs[0];
                var team = inputs[1];

                if (!TopUniversities.ContainsKey(university))
                {
                    TopUniversities.Add(university, team);
                }
            }

            var count = 0;
            var maxCount = 12;
            foreach (var item in TopUniversities)
            {
                Console.WriteLine(item.Key + " " + item.Value);
                count++;
                if (count >= maxCount) break;
            }
        }
    }
}
