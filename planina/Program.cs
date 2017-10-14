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
            int n = int.Parse(Console.ReadLine());
            int side = 2;
            for (int i = 1; i <= n; i++)
            {
                side += side - 1;
            }
            int sum = side * side;

            Console.WriteLine(sum);
        }
    }
}
