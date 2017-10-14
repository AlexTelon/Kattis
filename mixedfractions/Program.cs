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

            while(true)
            {
                var tokens = Console.ReadLine().Split().Select(ulong.Parse).ToList();
                var a = tokens[0];
                var b = tokens[1];
                if (a == 0 && b == 0) break;

                var rest = a % b;

                var number = Math.Floor((double) a / b);

                Console.WriteLine(string.Format("{0} {1} / {2}", number, rest, b));
            }
        }s
    }
}
