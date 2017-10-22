using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        class Solver
        {
            public int WalkingDist;

            public Solver()
            {
                int n = int.Parse(Console.ReadLine());
                List<int> stores = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToList();

                int min = stores[0];
                int max = stores[stores.Count() - 1];

                WalkingDist = (max - min) * 2;

            }
        }

        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var solver = new Solver();
                Console.WriteLine(solver.WalkingDist);
            }
        }
    }
}
