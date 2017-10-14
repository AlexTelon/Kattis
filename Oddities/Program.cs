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
            var results = new List<string>();

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                string text = "is odd";
                if (x % 2 == 0) text = "is even";

                results.Add(x + " " + text);
            }


            Console.WriteLine(String.Join("\n", results));
        }
    }
}
