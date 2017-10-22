using System;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            long area = long.Parse(Console.ReadLine()); // should be safe up to 10^19c# 
            double side = Math.Sqrt(area);
            double length = 4 * side;
            Console.WriteLine(length);
        }
    }
}
