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
            // nr of lines
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                onePassSolve();
            }
        }

        /// <summary>
        /// Solve it doing a single pass with some modulu things.
        /// </summary>
        private static void onePassSolve()
        {
            var line = Console.ReadLine();

            // counts is always the square of a length so no need to check for edge cases
            var count = line.Count();

            // the side is the length of the square of the length.
            int side = (int)Math.Floor(Math.Sqrt(count));

            var stringbuilder = new StringBuilder();

            int counter = 0;

            // ugly but fun for-loop
            for (int pos = side - 1; stringbuilder.Length < count; pos += side)
            {
                stringbuilder.Append(line[pos % count]);
                counter++;

                // every time we have read one "column" of the final data we do a minor ofset
                if (counter % side == 0)
                {
                    // move the position one step back so that the next time we move over the array we are looking at the column to the left.
                    pos--;
                }
            }

            Console.WriteLine(stringbuilder);
        }
    }
}
