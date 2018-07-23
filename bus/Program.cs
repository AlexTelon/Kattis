using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int stops = int.Parse(Console.ReadLine());

                var passangers = NrOfPassangersAtStart(stops);
                Console.WriteLine(passangers);
            }
        }

        private static double NrOfPassangersAtStart(int k)
        {
            double passangers = 1;
            for (int i = 0; i < k - 1; i++)
            {
                passangers = 2 * (passangers + 0.5);
            }

            return passangers;
        }
    }
}
