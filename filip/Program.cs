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
            var tokens = Console.ReadLine().Split().ToList();

            var a = int.Parse(new String(tokens[0].ToCharArray().Reverse().ToArray()));
            var b = int.Parse(new String(tokens[1].ToCharArray().Reverse().ToArray()));

            Console.WriteLine(Math.Max(a,b));
        }
    }
}
