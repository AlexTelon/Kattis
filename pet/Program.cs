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

            List<int> results = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                results.Add(tokens.Sum());
            }

            int max = results.Max();
            int winner = results.FindIndex(x => x == max);

            // winner represented from index 1
            Console.WriteLine(++winner + " " + max);
        }
    }
}
