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
            var cups = new List<Tuple<int, string>>();
            for (int i = 0; i < n; i++)
            {
                List<string> tokens = Console.ReadLine().Split().ToList();
                int radius;
                string color;
                if (int.TryParse(tokens[0], out radius))
                {
                    color = tokens[1];
                    radius /= 2;
                } else
                {
                    color = tokens[0];
                    radius = int.Parse(tokens[1]);
                }

                cups.Add(new Tuple<int, string>(radius, color));
            }

            var orderedCups = cups.OrderBy(x => x.Item1).Select(x => x.Item2).ToList();
            Console.WriteLine(String.Join("\n", orderedCups));
        }
    }
}
