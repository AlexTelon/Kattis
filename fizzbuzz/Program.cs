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

            int x = tokens[0];
            int y = tokens[1];
            int n = tokens[2];

            for (int i = 1; i < n+1; i++)
            {
                string print = "";

                if (i % x == 0) print = "Fizz";
                if (i % y == 0) print += "Buzz";

                Console.WriteLine((print != "") ? print : i.ToString());
            }
        }
    }
}
