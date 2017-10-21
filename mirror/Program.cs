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
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine("Test {0}", i + 1);
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

                int r = tokens[0];
                int c = tokens[1];

                int widthShift = r - 1;
                int heightShift = c - 1;

                char[,] matrix = new char[r, c];

                for (int y = 0; y < r; y++)
                {
                    string row = Console.ReadLine();
                    for (int x = 0; x < c; x++)
                    {
                        matrix[widthShift - y, heightShift - x] = row[x];
                    }
                }

                for (int y = 0; y < r; y++)
                {
                    for (int x = 0; x < c; x++)
                    {
                        Console.Write(matrix[y, x]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
