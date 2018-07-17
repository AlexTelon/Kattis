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
            int problems = tokens[0];
            int testsPerProblem = tokens[1];

            int sum = 0;

            while (problems > 0)
            {
                var testCases = new List<string>();
                for (int i = 0; i < testsPerProblem; i++)
                {
                    var input = Console.ReadLine();
                    input = char.ToLower(input[0]) + input.Substring(1);
                    testCases.Add(input);
                }

                if (AllAreLowerCase(testCases))
                {
                    sum++;
                }

                problems--;
            }

            Console.WriteLine(sum);
        }

        private static bool AllAreLowerCase(List<string> testCases)
        {
            foreach (var test in testCases)
            {
                if (test.Any(Char.IsUpper)) return false;
            }
            return true;
        }
    }
}
