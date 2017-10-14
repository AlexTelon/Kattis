using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = tokens[0];
            int m = tokens[1];

            // if one is larger all values between the smallest and the largest one + 1 are the most popular ones
            // if both are equal its just the smallest + 1 (both being equally small)
            // Imagine the diagonal created between a pair of x and y.
            // Where can we create the longest diagonal? And what are the values along those diagonals if we do x + y.
            var results = Enumerable.Range(Math.Min(n,m)+1, Math.Abs(n - m)+1).ToList();

            Console.WriteLine(String.Join("\n", results));
        }
    }
}
