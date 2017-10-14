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
            var results = new List<HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                int trips = int.Parse(Console.ReadLine());
                results.Add(new HashSet<string>());
                for (int j = 0; j < trips; j++)
                {
                    string city = Console.ReadLine();
                    results[i].Add(city);
                }
            }

            Console.WriteLine(String.Join("\n", results.Select(x => x.Count)));
        }
    }
}
