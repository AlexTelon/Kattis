using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int startContestant = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int endTime = 210;
            int currentTime = 0;
            int contestant = (startContestant - 1) % 8; // change to 0-7

            while (true)
            {
                var tokens = Console.ReadLine().Split();
                int time = int.Parse(tokens[0]);
                bool correct = tokens[1][0] == 'T';

                currentTime += time;

                if (currentTime >= endTime) // > or >= both give error on the 3rd last test.
                {
                    Console.WriteLine(contestant+1); // convert 0-7 range to 1-8 range
                    return;
                }

                if (correct)
                {
                    contestant = (contestant + 1) % 8;
                }
            }
        }
    }
}
