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
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            tokens.Sort();

            int x = tokens[0];
            int y = tokens[2];
            int sum = x * y;

            Console.WriteLine(sum);
        }
    }
}
