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
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine(radius * radius * Math.PI);

            double r2 = 2 * radius * radius;

            Console.WriteLine(r2);
        }
    }
}
