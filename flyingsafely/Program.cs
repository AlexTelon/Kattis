using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1..100]
            int testCases = int.Parse(Console.ReadLine());

            // find the least number of pilots that we need to trust to be able to move from any two cities
            // i.e find the longest path in a graph
            // it is given that the graph is connected.
            
            for (int testCase = 0; testCase < testCases; testCase++)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                var n = tokens[0]; // [2..1000] // cities
                var m = tokens[1]; // [1..10000] // pilots

                // loop over a bunch of lines, one for each pilot
                for (int i = 0; i < m; i++)
                {
                    // find the cities we are travelling between
                    var cities = Console.ReadLine().Split().Select(int.Parse).ToList();
                    var a = cities[0];
                    var b = cities[1];

                    // pilot i flies back and forth between a and b.
                }

                // tried to do a proof why we dont need to know any details about the actual cities..

                // 1. we have n cities

                // 2. only one pilot travels between any cities a and b.

                // 3. no pilot travels from a to a.

                // 4. we can go from all cities to all other cities
                //  => we have at least n - 1 pilots, otherwise we cannot reach all cities
                // imagine cities, A B C D E
                // pilots are arrows ->
                // A -> B -> C -> D -> E
                // this is a optimal number of pilots to trust

                // 5. all cities have names [1..n]
                // 6. no city have the same name as another one
                // => structure could be shown as this:
                // A -> 
                // B -> 
                // C -> 
                // ..
                // where every line is represented on the left hand side at least once.
                // we dont care about the right hand side, but since it must satisfy the fact that we can travel to any other city all A .. X must be represented on the right hand side at least once.
                // We only care about the number of arrows, not anything else, and since N nodes need N-1 edges we are done, i think..

                Console.WriteLine(n - 1);
            }
        }
    }
}
