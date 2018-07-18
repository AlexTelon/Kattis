using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int time = tokens[1];

            List<int> tasks = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            int count = 0;
            foreach (var task in tasks)
            {
                sum += task;
                if (sum > time) break;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
