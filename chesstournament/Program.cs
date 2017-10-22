using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {

        class Node
        {
            public List<int> GreaterPlayers = new List<int>();
            public List<int> LesserPlayers = new List<int>();
            public List<int> EqualPlayers = new List<int>();

            internal void JoinEqualPlayer(List<int> equal)
            {
                // Check for inconsistency at this stage?
                EqualPlayers.AddRange(equal);
            }

            internal void JoinLesser(List<int> lesser)
            {
                LesserPlayers.AddRange(lesser);
            }

            internal void JoinGreater(List<int> greater)
            {
                GreaterPlayers.AddRange(greater);
            }

        }

        class Results
        {
            private Node[] results;

            public Results(int players)
            {
                results = new Node[players];
            }

            public Node this[int i]
            {
                get
                {
                    if (results[i] == null) results[i] = new Node();
                    return results[i];
                }
                set
                {
                    if (results[i] == null)
                    {
                        results[i] = value;
                    }
                    else
                    {
                        //merge results
                        results[i].JoinEqualPlayer(value.EqualPlayers);
                        results[i].JoinLesser(value.LesserPlayers);
                        results[i].JoinGreater(value.GreaterPlayers);
                    }

                }
            }

            internal void FindAllEqualTo(List<int> players, HashSet<int> stuff)
            {
                if (players.Count == 0) return;

                //List<int> stuff = new List<int>();
                foreach (var id in players)
                {
                    stuff.Add(id);

                    // are there any new equalplayers?

                    var newPlayers = results[id].EqualPlayers.Where(x => !stuff.Contains(x)).ToList();

                    FindAllEqualTo(newPlayers, stuff);
                }

            }

            internal HashSet<int> FindAllEqualTo(int p2)
            {
                // send in list of all found so far
                var stuff = new HashSet<int>() { p2 };
                // make sure to call results through the indexer here so it can handle if p2 is null
                FindAllEqualTo(this[p2].EqualPlayers, stuff);
                return stuff;
            }


            internal void FindAllLesserOrEqual(List<int> players, HashSet<int> stuff)
            {
                foreach (var id in players)
                {
                    stuff.Add(id);

                    var newEqualPlayers = results[id].EqualPlayers.Where(x => !stuff.Contains(x)).ToList();
                    FindAllLesserOrEqual(newEqualPlayers, stuff);

                    var newLesserPlayers = results[id].LesserPlayers.Where(x => !stuff.Contains(x)).ToList();
                    FindAllLesserOrEqual(newLesserPlayers, stuff);
                    // these two are not needed since these are added in the recursive call.
                    //stuff.AddRange(results[id].LesserPlayers); // add all that are smaller than us
                    //stuff.AddRange(results[id].EqualPlayers); // all all that are equal to us

                    //var newPlayers = 

                    //stuff.AddRange(FindAllLesserOrEqual(results[id].LesserPlayers)); // find all lesser to our lessers

                    //stuff.AddRange(FindAllLesserOrEqual(results[id].EqualPlayers)); // find all equal to our lessers // EXCLUDED DUE TO INFINITE LOOP, NEED TO MAKE SURE NOT ONLY INCLUDE NEW PLAYERS SOMEHOW
                }

                //make sure these are added too
                //stuff.AddRange(players);
                //return stuff;
            }

            internal HashSet<int> FindAllLesser(int p2)
            {
                var stuff = new HashSet<int>();
                // make sure to call results through the indexer here so it can handle if p2 is null
                FindAllLesserOrEqual(this[p2].LesserPlayers, stuff); // find all p2 > x
                return stuff;
            }

            internal HashSet<int> FindAllGreater(int p2)
            {
                var stuff = new HashSet<int>();
                // make sure to call results through the indexer here so it can handle if p2 is null 
                FindAllGreaterOrEqual(this[p2].GreaterPlayers, stuff);
                return stuff;
            }

            private void FindAllGreaterOrEqual(List<int> players, HashSet<int> stuff)
            {
                foreach (var id in players)
                {
                    stuff.Add(id);

                    var newGreaterPlayers = results[id].GreaterPlayers.Where(x => !stuff.Contains(x)).ToList();
                    FindAllGreaterOrEqual(newGreaterPlayers, stuff);

                    var newEqualPlayers = results[id].EqualPlayers.Where(x => !stuff.Contains(x)).ToList();
                    FindAllGreaterOrEqual(newEqualPlayers, stuff);


                    // these two are not needed since these are added in the recursive call.
                    //stuff.AddRange(results[id].GreaterPlayers); // add all greater players
                    //stuff.AddRange(results[id].EqualPlayers); // add all equal players

                    //stuff.AddRange(FindAllGreaterOrEqual(results[id].GreaterPlayers)); // find all greater than our greater
                    //stuff.AddRange(FindAllGreaterOrEqual(results[id].EqualPlayers)); // find all equal to our greater // EXCLUDED DUE TO INFINITE LOOP, NEED TO MAKE SURE NOT ONLY INCLUDE NEW PLAYERS SOMEHOW

                }

                //make sure these are added too
                //stuff.AddRange(players);

                //return stuff;
            }
        }


        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int players = tokens[0]; // 2 - 50 000 players
            int matches = tokens[1]; // 1 - 250 000 matches

            var results = new Results(players);

            List<string> result;
            int p1, p2;
            char op;
            Node node;

            // Data gathering of all but the last data point into data structure
            for (int i = 0; i < matches - 1; i++)
            {
                result = Console.ReadLine().Split().ToList();
                p1 = int.Parse(result[0]);
                op = char.Parse(result[1]);
                p2 = int.Parse(result[2]);

                node = new Node();

                if (op == '>') node.LesserPlayers.Add(p2);
                else
                {
                    node.EqualPlayers.Add(p2);
                    results[p2].EqualPlayers.Add(p1);
                }

                results[p1] = node;
            }
            // The above data is correctly reported

            // See if this last one is inconsistent with the other data

            result = Console.ReadLine().Split().ToList();
            int a = int.Parse(result[0]);
            op = char.Parse(result[1]);
            int b = int.Parse(result[2]);

            node = new Node();
            if (op == '>') node.LesserPlayers.Add(b);
            else node.EqualPlayers.Add(b);

            // ok so we have our last node.

            HashSet<int> bEqual = results.FindAllEqualTo(b); // all players equal to b
            HashSet<int> bSmaller = results.FindAllLesser(b); // all players weaker than b
            HashSet<int> bLarger = results.FindAllGreater(b); // all players stronger than b

            if (op == '>')
            {
                // Everythin in bGroup must be smaller than a, no other relation may exist to a
                List<int> bGroup = new List<int>();
                bGroup.AddRange(bEqual);
                bGroup.AddRange(bSmaller);

                if (bGroup.Any(x => x == a))
                {
                    // inconsistent! We found someone in bGroup that is greater or equal to a!
                    Console.WriteLine("inconsistent");
                    return;
                }

                Console.WriteLine("consistent");
                return;
            }
            else
            {
                //HashSet<int> aEqual = results.FindAllEqualTo(a); // all players equal to a
                HashSet<int> aSmaller = results.FindAllLesser(a); // all players weaker than a
                HashSet<int> aLarger = results.FindAllGreater(a); // all players stronger than a

                if (bLarger.Any(x => x == a))
                {
                    //inconsistent, a cannot be both larger and equal to b
                    Console.WriteLine("inconsistent");
                    return;
                }

                if (bSmaller.Any(x => x == a))
                {
                    //inconsistent, a cannot be smaller and equal to b
                    Console.WriteLine("inconsistent");
                    return;
                }

                if (aLarger.Any(x => x == b))
                {
                    //inconsistent, a cannot be both larger and equal to b
                    Console.WriteLine("inconsistent");
                    return;
                }

                if (aSmaller.Any(x => x == b))
                {
                    //inconsistent, a cannot be smaller and equal to b
                    Console.WriteLine("inconsistent");
                    return;
                }



                Console.WriteLine("consistent");
                return;
            }
        }
    }
}
