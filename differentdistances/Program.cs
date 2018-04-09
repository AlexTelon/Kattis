using System;
using System.Globalization;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var tokens = Console.ReadLine().Split().Select(x => double.Parse(x, CultureInfo.InvariantCulture)).ToList();

                // coordinates in (0..100] range
                var x1 = tokens[0];
                if (x1 == 0) return;
                var y1 = tokens[1];
                var x2 = tokens[2];
                var y2 = tokens[3];

                var p = tokens[4]; // [0.1 .. 10]

                var a = Math.Abs(x1 - x2);
                var b = Math.Abs(y1 - y2);

                var dist = Math.Pow(Math.Pow(a, p) + Math.Pow(b, p), (1 / p));
                Console.WriteLine(dist);
            }
        }
    }
}
