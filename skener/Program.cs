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
            int r = tokens[0];
            int c = tokens[1];
            int zr = tokens[2];
            int zc = tokens[3];

            for (int i = 0; i < r; i++)
            {
                string line = Console.ReadLine();

                string transformedLine = "";

                foreach (var token in line)
                {
                    transformedLine += new string(token, zc);
                }

                for (int j = 0; j < zr; j++)
                {
                    Console.WriteLine(transformedLine);
                }
            }
        }
    }
}
