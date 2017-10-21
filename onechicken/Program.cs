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
            int guests = tokens[0];
            int chickens = tokens[1];

            int delta = chickens - guests;

            if (delta == 1)
            {
                Console.WriteLine("Dr. Chaz will have 1 piece of chicken left over!");
            }
            else if (delta == -1)
            {
                Console.WriteLine("Dr. Chaz needs 1 more piece of chicken!");
            }
            else if (delta > 0)
            {
                Console.WriteLine("Dr. Chaz will have {0} pieces of chicken left over!", delta);
            }
            else
            {
                Console.WriteLine("Dr. Chaz needs {0} more pieces of chicken!", Math.Abs(delta));
            }
        }
    }
}
