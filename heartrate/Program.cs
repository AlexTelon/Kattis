using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            // usecases [1..1000]
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().ToList();
                var b = int.Parse(tokens[0]); // [2..1000]
                var p = double.Parse(tokens[1], CultureInfo.InvariantCulture); // [0..1000]

                var BPM = 60 * b / p;

                var t = (b + 1) / p;
                var max_ABPM = 60 * t;

                t = (b - 1) / p;
                var min_ABPM = 60 * t;


                Console.WriteLine(min_ABPM + " " + BPM + " " + max_ABPM);
            }

            var results = new List<string>();
        }
    }
}
