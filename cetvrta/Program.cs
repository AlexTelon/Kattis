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
            List<int> xVals = new List<int>();
            List<int> yVals = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                xVals.Add(tokens[0]);
                yVals.Add(tokens[1]);
            }

            int x = xVals[0];
            if (xVals[0] == xVals[1]) x = xVals[2];
            if (xVals[0] == xVals[2]) x = xVals[1];


            int y = yVals[0];
            if (yVals[0] == yVals[1]) y = yVals[2];
            if (yVals[0] == yVals[2]) y = yVals[1];

            Console.WriteLine(x + " " + y);
        }
    }
}
