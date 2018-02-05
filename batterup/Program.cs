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

            var num = int.Parse(Console.ReadLine());

            List<int> bats = Console.ReadLine().Split().Select(int.Parse).ToList();

            double sum = 0;

            foreach (var score in bats)
            {
                if (score == -1)
                {
                    num--;
                    continue;
                }
                sum += score;
            }

            // num is guaranteed to be over 0
            var average = sum / num;

            Console.WriteLine(average);
        }
    }
}
