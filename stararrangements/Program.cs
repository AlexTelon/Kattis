using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            // the number of stars we should have
            // stars is >= 3
            var stars = int.Parse(Console.ReadLine());
            int maxWidth = (int)Math.Ceiling(((double)stars) / 2);

            Console.WriteLine(stars + ":");


            for (int firstRowWidth = 2; firstRowWidth <= maxWidth; firstRowWidth++)
            {
                PrintAppealingFlagIfExist(firstRowWidth, stars);
            }

        }

        private static void PrintAppealingFlagIfExist(int width, int stars)
        {

            // start with the width - 1 so the print order is right
            if (IsAppealing(width, width - 1, stars))
            {
                Console.WriteLine(width + "," + (width - 1));
            }

            if (IsAppealing(width, width, stars))
            {
                Console.WriteLine(width + "," + width);
            }
        }

        private static bool IsAppealing(int firstRow, int secondRow, int stars)
        {
            var sum = 0;
            var i = 0;

            while (sum <= stars)
            {
                if (i % 2 == 0)
                {
                    sum += firstRow;
                }
                else
                {
                    sum += secondRow;
                }

                if (sum == stars)
                {
                    return true;
                }
                i++;
            }

            return false;
        }

    }
}
