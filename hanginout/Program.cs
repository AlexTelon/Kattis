using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine().Split().Select(int.Parse).ToList();

            var maxAllowed = info[0];
            var events = info[1];

            var peopleOnRoof = 0;
            var deniedCount = 0;

            for (int i = 0; i < events; i++)
            {
                var input = Console.ReadLine().Split();

                string action = input[0];
                int people = int.Parse(input[1]);

                if (action == "enter")
                {
                    peopleOnRoof += people;

                    if (peopleOnRoof > maxAllowed)
                    {
                        peopleOnRoof -= people;
                        deniedCount++;
                    }

                } else if (action == "leave")
                {
                    peopleOnRoof -= people;
                } else
                {
                    throw new Exception("huh?");
                }
            }

            Console.WriteLine(deniedCount);
        }
    }
}
