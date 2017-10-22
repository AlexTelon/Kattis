using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        int[] arrayA = new int[46];
        int[] arrayB = new int[46];

        int A(int i)
        {
            if (i == 0) return 1;
            if (i == 1) return 0;

            if (arrayA[i] == 0)
            {
                arrayA[i] = B(i - 1);
            }
            return arrayA[i];
        }

        int B(int i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;

            if (arrayB[i] == 0)
            {
                arrayB[i] = B(i - 1) + A(i - 1);
            }
            return arrayB[i];
        }

        static void Main(string[] args)
        {
            // 1-45
            int k = int.Parse(Console.ReadLine());

            var program = new Program();

            Console.WriteLine(program.A(k) + " " + program.B(k));

        }
    }
}
