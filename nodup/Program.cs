using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToList();

            // check for dups
            var duplicates = (words.Count() != words.Distinct().Count());

            if (!duplicates)
            {
                Console.WriteLine("yes");
            } else
            {
                Console.WriteLine("no");
            }
        }
    }
}
