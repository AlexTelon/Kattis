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
            double sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string p = Console.ReadLine();
                int number = int.Parse(p.Substring(0, p.Length - 1));
                int power = (int)Char.GetNumericValue(p[p.Length - 1]);

                sum += Math.Pow(number, power);
            }

            Console.WriteLine(sum);
        }
    }
}