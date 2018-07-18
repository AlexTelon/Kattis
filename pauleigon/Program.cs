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
            int rounds = tokens[0];
            int paulScore = tokens[1];
            int opponentScore = tokens[2];

            int totalRounds = paulScore + opponentScore;
            //hackitihack, its one point per round so quickfix here
            totalRounds /= rounds;

            bool even = totalRounds % 2 == 0;

            if (even)
            {
                Console.WriteLine("paul");
            }
            else
            {
                Console.WriteLine("opponent");
            }
        }
    }
}
