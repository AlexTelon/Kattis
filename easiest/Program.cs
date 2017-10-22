using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        // slow string version
        // if needed to int /10 solution in loop
        static int DigitSum(int number)
        {
            string num = number.ToString();
            int sum = 0;

            foreach (var token in num)
            {
                sum += int.Parse("" + token);
            }
            return sum;
        }


        static void Main(string[] args)
        {
            while (true)
            {

                // < 100 000
                int n = int.Parse(Console.ReadLine());
                if (n == 0) return;

                int goal = DigitSum(n);

                // solutions must be over 10
                int i = 10;

                while (true)
                {
                    if (DigitSum(++i * n) == goal) break;
                }

                Console.WriteLine(i);

            }
        }
    }
}
