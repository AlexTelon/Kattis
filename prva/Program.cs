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
            int height = tokens[0];
            int width = tokens[1];

            var verticalLines = new string[width];

            var allWords = new List<string>();

            for (int y = 0; y < height; y++)
            {
                var line = Console.ReadLine();
                
                // adding all horizontal words as we go
                var words = (line).Split('#').Where(x => x.Length > 1).ToList();
                allWords.AddRange(words);

                // save the data in a way so its easy to read the vertical lines once all horizontal lines have been read
                for (int x = 0; x < line.Length; x++)
                {
                    var currentChar = line[x];
                    verticalLines[x] += currentChar;
                }
            }

            foreach (var line in verticalLines)
            {
                // adding all horizontal words as we go
                var words = (line).Split('#').Where(x => x.Length > 1).ToList();
                allWords.AddRange(words);
            }


            var lexicographicallySmalles = allWords.OrderBy(s => s).First();
            Console.WriteLine(lexicographicallySmalles);
        }
    }
}
