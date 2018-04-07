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
            while (true)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                int x = tokens[0];
                int y = tokens[1];

                if (x == 0 && y == 0) return;

                string output = "Left beehind.";

                if (x + y == 13)
                {
                    Console.WriteLine("Never speak again.");
                    continue;
                }

                if (x == y) output = "Undecided.";
                if (x > y) output = "To the convention.";

                Console.WriteLine(output);
            }
        }
    }
}
