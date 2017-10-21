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
                int sum = 0;
                List<int> years = Console.ReadLine().Split().Select(int.Parse).ToList();
                // last one is not a real value
                years.RemoveAt(years.Count - 1);

                int previous = years[0];
                sum += years[0] - 1;
                if (years.Count <= 1)
                {
                    Console.WriteLine(sum);
                    continue;
                }

                // hear me out, years could be named populations, but years makes this line here like english! Cool huh!
                // dont write production code like this!
                foreach (var population in years.Skip(1))
                {
                    sum += Math.Max(0, (population - previous * 2));
                    previous = population;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
