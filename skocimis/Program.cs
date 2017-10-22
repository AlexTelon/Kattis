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
            int a = tokens[0];
            int b = tokens[1];
            int c = tokens[2];

            int spaceEnd = Math.Max(0, Math.Abs(b - c) - 1);
            int spaceStart = Math.Max(0, Math.Abs(a - b) - 1);

            Console.WriteLine(Math.Max(spaceStart, spaceEnd));
        }
    }
}
