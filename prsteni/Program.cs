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

            List<int> radiuses = Console.ReadLine().Split().Select(int.Parse).ToList();

            var first = radiuses[0];
            // since circumference is always 2 PI r, and we are using fractions betweent hem only r matters.
            foreach (var current in radiuses.Skip(1))
            {
                Console.WriteLine(GetReducedFormFraction(first, current));
            }
        }

        private static int GCD(int a, int b)
        {
            if (a < 0 || b < 0) throw new Exception("non negative numbers not allowed!");
            //if (b == 0) return a;

            if (a > b) return GCD(a - b, b);
            else if (a == b) return a;
            else return GCD(a, b - a);
        }

        private static string GetReducedFormFraction(int larger, int smaller)
        {
            var gcd = GCD(larger, smaller);

            int numerator = larger / gcd;
            int denumerator = smaller / gcd;

            return "" + numerator + "/" + denumerator;
        }
    }
}
