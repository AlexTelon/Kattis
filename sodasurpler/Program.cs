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

            var bottles = tokens[0] + tokens[1];
            var cost = tokens[2];

            // he has not drunk any bottles yet
            var sum = 0;

            // while we have enought bottles to buy more
            while (bottles >= cost)
            {
                //buy a new one
                bottles -= cost;
                //drink it
                sum++;

                // gain a new empty one (since he drank it)
                bottles++;
            }

            Console.WriteLine(sum);
        }
    }
}
