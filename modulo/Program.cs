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
            var modulu = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                modulu.Add(number % 42);
            }

            Console.WriteLine(modulu.Count);
        }
    }
}
