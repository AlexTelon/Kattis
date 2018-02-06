using System;
using System.Linq;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine();
                
                if (line == "P=NP")
                {
                    Console.WriteLine("skipped");
                    continue;
                }

                var arguments = line.Split('+').Select(int.Parse).ToList();

                Console.WriteLine(arguments[0] + arguments[1]);
            }
        }
    }
}
