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
            public List<int> LargerThan = new List<int>();
            public List<int> Equal = new List<int>();

            internal void JoinEqual(List<int> equal)
            {
                // Check for inconsistency at this stage?
                Equal.AddRange(equal);
                //throw new NotImplementedException();
            }

            internal void JoinLargerThan(List<int> largerThan)
            {
                Equal.AddRange(largerThan);
                //throw new NotImplementedException();
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
                    } else
                    {
                        //merge results
                        results[i].JoinEqual(value.Equal);
                        results[i].JoinLargerThan(value.LargerThan);
                    }

                }
            }
        }


        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int players = tokens[0]; // 2 - 50 000 players
            int matches = tokens[1]; // 1 - 250 000 matches

            var results = new Results(players);

            // Data gathering into data structure
            for (int i = 0; i < matches; i++)
            {
                List<string> result = Console.ReadLine().Split().ToList();
                int p1 = int.Parse(result[0]);
                char op = char.Parse(result[1]);
                int p2 = int.Parse(result[2]);

                Node node = new Node();

                if (op == '>') node.LargerThan.Add(p2);
                else
                {
                    node.Equal.Add(p2);
                    results[p2].Equal.Add(p1);
                }

                results[p1] = node;
            }


            // Check data for validity

            Console.WriteLine("done");
        }
    }
}
