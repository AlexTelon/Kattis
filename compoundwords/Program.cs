using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = GetWords();
            // a sorted set of all compound words
            SortedSet<string> compoundWords = new SortedSet<string>();

            // we want to match every word with every other word (but not itself)
            //   abcdefg
            // a  xxxxxx
            // b x xxxxx
            // c xx xxxx
            // d xxx xxx
            // e xxxx xx
            // f xxxxx x
            // g xxxxxx
            // we want to do a match for every x above, but ignore the diagonal with itself
            for (int row = 0; row < words.Count(); row++)
            {
                for (int col = 0; col < words.Count(); col++)
                {
                    // skip the self-diagonal
                    if (row == col) continue;

                    compoundWords.Add(words[row] + words[col]);
                }
            }

            Console.WriteLine(String.Join("\n", compoundWords));
        }

        private static List<string> GetWords()
        {
            var words = new List<string>();
            
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                var wordsFromLine = line.Split();

                // exit loop there is no real words left (empty string is expected on final empty line)
                if (!wordsFromLine.Any(x => x.Length > 0)) break; // no more data

                words.AddRange(wordsFromLine);
            }

            return words;
        }
    }
}
