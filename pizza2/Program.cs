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
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int r = tokens[0];
            int crust = tokens[1];

            int crustR = r - crust;

            double pizzaArea = r * r * Math.PI;
            double cheeseArea = crustR * crustR * Math.PI;

            Console.WriteLine(cheeseArea / pizzaArea * 100);
        }
    }
}
