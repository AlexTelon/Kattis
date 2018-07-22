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
            // 1 < N <= 1000
            int maxLowerBound = 0;
            int minMaxBound = 1001;

            for (int i = 0; i < n; i++)
            {

                var times = Console.ReadLine().Split().Select(int.Parse).ToList();
                // a < b is given
                int a = times[0];
                int b = times[1];

                maxLowerBound = Math.Max(maxLowerBound, a);
                minMaxBound = Math.Min(minMaxBound, b);
            }

            if (maxLowerBound <= minMaxBound)
            {
                Console.WriteLine("gunilla has a point");
            } else
            {
                Console.WriteLine("edward is right");
            }

        }
    }
}
