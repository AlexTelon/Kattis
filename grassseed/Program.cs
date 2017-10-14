using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var cost = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // per square meter

            int n = int.Parse(Console.ReadLine()); // per square meter
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split().Select(t => double.Parse(t, CultureInfo.InvariantCulture)).ToList();
                var x = tokens[0];
                var y = tokens[1];

                sum += x * y * cost;
            }

            Console.WriteLine(sum.ToString("#.########"));
        }
    }
}
