using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int length = LengthOfLoop();

                Console.WriteLine("Case #{0}: {1}", (i + 1), length);
            }

        }

        private static int LengthOfLoop()
        {
            Console.ReadLine(); // dont care value

            var redRopes = new List<int>();
            var blueRopes = new List<int>();

            List<string> ropes = Console.ReadLine().Split().ToList();

            foreach (var rope in ropes)
            {
                int value = int.Parse(rope.Substring(0, rope.Length - 1)); // all but last
                var color = rope[rope.Length - 1]; // last

                if (color == 'R')
                {
                    redRopes.Add(value);
                }
                else
                {
                    blueRopes.Add(value);
                }
            }

            if (redRopes.Count() == 0 || blueRopes.Count() == 0)
            {
                return 0;
            }

            int length = 0;

            redRopes = redRopes.OrderByDescending(x => x).ToList();
            blueRopes = blueRopes.OrderByDescending(x => x).ToList();

            var maxIndex = Math.Min(redRopes.Count(), blueRopes.Count());

            for (int i = 0; i < maxIndex; i++)
            {
                var red = redRopes[i];
                var blue = blueRopes[i];

                length += red + blue - 2;
            }

            return length;
        }
    }
}