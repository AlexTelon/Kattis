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
                double calories = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Ceiling(calories / 400));
            }
        }
    }
}