using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        public class Solver
        {
            private double[] numbers = new double[3];

            private double a { get { return numbers[0]; } }
            private double b { get { return numbers[1]; } }
            private double c { get { return numbers[2]; } }


            public bool Possible()
            {
                // oups only need to check if a operator b == c..
                for (int i = 0; i < 1; i++)
                {
                    //int a = numbers[i];
                    //int b = numbers[(i + 1) % 3];
                    //int c = numbers[(i + 2) % 3];

                    if (a + b == c || a - b == c || b -a == c || a * b == c || a / b == c || b / a == c)
                    {
                        return true;
                    }
                }
                return false;
            }

            public Solver(int a, int b, int c)
            {
                numbers = new double[3] { a, b, c };
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                int a = tokens[0];
                int b = tokens[1];
                int c = tokens[2];
                // no number is 0

                var solver = new Solver(a, b, c);
                    
                if (solver.Possible())
                {
                    Console.WriteLine("Possible");
                } else
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}
