using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (input[1] % 2 == 0)
            {
                Console.WriteLine("possible");
            } else
            {
                Console.WriteLine("impossible");
            }
        }
    }
}