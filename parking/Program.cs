using System;
using System.Collections.Generic;
using System.Linq;

namespace Kattis
{
    class Program
    {
        class Time
        {
            public int Start;
            public int Stop;

            public bool IsParked(int t)
            {
                return t >= Start && t < Stop;
            }
            public override string ToString()
            {
                return Start + ", " + Stop;
            }
        }
        static void Main(string[] args)
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> parkingCosts = new List<int>() { 0, tokens[0], tokens[1], tokens[2] };

            int cost = 0;

            var trucks = new List<Time>();
            // always just 3 trucks
            for (int i = 0; i < 3; i++)
            {
                var time = new Time();
                var times = Console.ReadLine().Split().Select(int.Parse).ToList();
                time.Start = times[0];
                time.Stop = times[1];

                trucks.Add(time);
            }

            var minTime = trucks.Select(x => x.Start).Min();
            var maxTime = trucks.Select(x => x.Stop).Max();

            for (int t = minTime; t <= maxTime; t++)
            {
                var parkedTrucks = trucks.Where(x => x.IsParked(t)).ToList().Count();
                cost += parkingCosts[parkedTrucks] * parkedTrucks;
            }
            Console.WriteLine(cost);
        }
    }
}
