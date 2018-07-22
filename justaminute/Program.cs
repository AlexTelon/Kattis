using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double reportedMinutes = 0;
            double realSecondsPassed = 0;

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                var M = tokens[0];
                var seconds = tokens[1];

                reportedMinutes += M;
                realSecondsPassed += seconds;
            }

            double realMinutesPassed = (realSecondsPassed / 60);

            var averageRealMinuteLength = realMinutesPassed / reportedMinutes;

            if (averageRealMinuteLength <= 1)
            {
                Console.WriteLine("measurement error");
                return;
            }
            Console.WriteLine(averageRealMinuteLength);
        }
    }
}
