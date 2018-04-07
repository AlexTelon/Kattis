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

            var firstLine = Console.ReadLine().Split();

            var hands = int.Parse(firstLine[0]);
            var handSize = 4;
            var cards = hands * handSize;

            // always just 1 char long
            var dominantSuit = firstLine[1][0];

            // These are the hardcoded rules of the game
            var dominant = new Dictionary<char, int>() {
                { 'A', 11 },
                { 'K', 4 },
                { 'Q', 3 },
                { 'J', 20 },
                { 'T', 10 },
                { '9', 14 },
                { '8', 0 },
                { '7', 0 }
            };
            var nonDominant = new Dictionary<char, int>() {
                { 'A', 11 },
                { 'K', 4 },
                { 'Q', 3 },
                { 'J', 2 },
                { 'T', 10 },
                { '9', 0 },
                { '8', 0 },
                { '7', 0 }
            };

            var score = 0;


            for (int i = 0; i < cards; i++)
            {
                var input = Console.ReadLine();
                var cardNumber = input[0];
                var cardSuit = input[1];

                var cardValue = 0;
                if (cardSuit == dominantSuit)
                {
                    cardValue = dominant[cardNumber];
                } else
                {
                    cardValue = nonDominant[cardNumber];
                }

                score += cardValue;
            }

            Console.WriteLine(score);
        }
    }
}
