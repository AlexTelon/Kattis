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

            for (int i = 0; i < n; i++)
            {
                Solve();
            }

        }

        private static void Solve()
        {
            List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

            var K = tokens[0]; // data set number
            var N = tokens[1]; // integer N

            var message = "" + K;

            message += " " + Sum(N, i => true);
            message += " " + Sum(N, i => i % 2 != 0);
            message += " " + Sum(N, i => i % 2 == 0);

            Console.WriteLine(message);
        }

        /// <summary>
        /// Sum all the first N numbers that matches a predicate
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int Sum(int n, Predicate<int> predicate)
        {
            var sum = 0;

            // counting how many times we have added a number that matches the predicate
            var counter = 0;

            for (int i = 1; counter < n; i++)
            {
                if (predicate(i))
                {
                    sum += i;
                    counter++;
                }
            }
            return sum;
        }
    }
}
