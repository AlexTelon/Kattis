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

            string line;
            while ((line = Console.ReadLine()) != null)
            {
                List<long> tokens = line.Split().Select(long.Parse).ToList();
                long a = tokens[0];
                long b = tokens[1];
                Console.WriteLine(Math.Abs(a - b));
            }
        }
    }
}
