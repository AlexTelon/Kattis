using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokens = Console.ReadLine();
            var results = new List<int>() {};

            var cards = new Dictionary<char, List<int>>
            {
                ['P'] = new List<int>(Enumerable.Range(1, 13)),
                ['K'] = new List<int>(Enumerable.Range(1, 13)),
                ['H'] = new List<int>(Enumerable.Range(1, 13)),
                ['T'] = new List<int>(Enumerable.Range(1, 13))
            };

            var m = Regex.Match(tokens, "([A-Z][0-9][0-9])");
            while (m.Success)
            {
                char suit = m.Value[0];
                int number = int.Parse(m.Value.Substring(1, 2));

                if (!cards[suit].Any(x => x == number))
                {
                    // we have had a copy this card already!
                    Console.WriteLine("GRESKA");
                    return;
                }

                cards[suit].Remove(number);
                m = m.NextMatch();
            }


            Console.WriteLine(String.Join(" ", cards.Select(x => x.Value.Count)));
        }
    }
}
