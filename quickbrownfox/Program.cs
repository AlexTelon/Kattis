using System;
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
                var inputstring = Console.ReadLine();

                string missingLetters = MissingLettersToBePangram(inputstring);

                if (string.IsNullOrEmpty(missingLetters))
                {
                    Console.WriteLine("pangram");
                } else
                {
                    Console.WriteLine("missing " + missingLetters);
                }
            }
        }

        private static string MissingLettersToBePangram(string inputstring)
        {
            string missing = "";
            foreach (var alphabet in "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower())
            {
                if (!inputstring.ToLower().Contains(alphabet))
                {
                    missing += alphabet;
                }
            }
            return missing;
        }
    }
}
