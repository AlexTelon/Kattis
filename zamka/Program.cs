using System;

namespace Kattis
{
    class Program
    {
        public static int SumOfDigits(int value)
        {
            var sum = 0;
            for (; value > 0; value /= 10)
            {
                sum += value % 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {


            int l = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            int n = -1; // l <= n <= d, maximal n, sum of digits is X
            int m = -1; // l <= m <= d, minimal m, sum of digits is X


            // 10000 is max L and D, 1 is min.
            // L is always <= D
            for (int i = l; i <= d; i++)
            {
                if (SumOfDigits(i) != x) continue;
                n = i;
                break;
            }

            //overshooting does not matter, we find the answer and quit
            for (int i = d; i >= l; i--)
            {
                if (SumOfDigits(i) != x) continue;
                m = i;
                break;
            }

            Console.WriteLine(n);
            Console.WriteLine(m);

        }
    }
}
