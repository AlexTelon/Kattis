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
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToList();

            int d = tokens[0] - 1; // 0 index here
            int m = tokens[1] - 1; // 0 index here
            //year is 2009

            List<int> monthLenght = new List<int>() { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // week start at monday
            List<string> weekDays = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int index = 3; // 2009 started on a thursday

            // add days of previous months
            index += monthLenght.Take(m).Sum();
            // add days of current months
            index += d;

            Console.WriteLine(weekDays[index % 7]);
        }
    }
}
