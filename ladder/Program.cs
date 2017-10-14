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

            int h = tokens[0]; // 1 - 10000
            double angle = tokens[1]; // 1 - 89
            angle = angle * Math.PI / 180;

            Console.WriteLine(Math.Ceiling(h / Math.Sin(angle)));
        }
    }
}
