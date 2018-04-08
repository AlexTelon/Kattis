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
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

                var num = tokens[0];

                tokens.RemoveAt(0);

                var gnomes = tokens;

                var prev = gnomes[0] - 1;

                var pos = 0;
                foreach (var current in gnomes)
                {
                    if (current - prev != 1)
                    {
                        break;
                    }
                    prev = current;
                    pos++;
                }
                Console.WriteLine(pos + 1);
            }
        }
    }
}
