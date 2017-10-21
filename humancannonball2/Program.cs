using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            for (int i = 0; i < n; i++)
            {
                List<double> values = Console.ReadLine().Split().Select(double.Parse).ToList();

                var v = values[0];
                var delta = values[1] * Math.PI / 180;
                var x = values[2];
                var h1 = values[3] + 1;
                var h2 = values[4] - 1;

                double t = x / ( v * Math.Cos(delta) );

                double height = v * t * Math.Sin(delta)  -  0.5 * 9.81 * t * t;

                if (height > h1 && height < h2) Console.WriteLine("Safe");
                else Console.WriteLine("Not Safe");
            }
        }
    }
}
