using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var gunnar = Console.ReadLine().Split().Select(int.Parse).ToList();

            var a1 = gunnar[0];
            var b1 = gunnar[1];
            var a2 = gunnar[2];
            var b2 = gunnar[3];

            // take the expected relative value, but always add the minimum value since that is always given
            double expected1 = a1 + (double)(b1 - a1) / 2;
            double expected2 = a2 + (double)(b2 - a2) / 2;
            var gunnarMean = expected1 + expected2;


            var emma = Console.ReadLine().Split().Select(int.Parse).ToList();

            a1 = emma[0];
            b1 = emma[1];
            a2 = emma[2];
            b2 = emma[3];

            double e_expected1 = a1 + (double)(b1 - a1) / 2;
            double e_expected2 = a2 + (double)(b2 - a2) / 2;
            var emmaMean = e_expected1 + e_expected2;

            var delta = gunnarMean - emmaMean;

            if (delta == 0)
            {
                Console.WriteLine("Tie");
            }
            else if (delta < 0)
            {
                Console.WriteLine("Emma");
            }
            else
            {
                Console.WriteLine("Gunnar");
            }

        }
    }
}
