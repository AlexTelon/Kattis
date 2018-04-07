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
            var first = true;
            while (true)
            {
                Solve(first);
                first = false;
            }
        }

        private static void Solve(bool first)
        {
            if (!first)
            {
                Console.WriteLine();
            }

            var len = int.Parse(Console.ReadLine());

            if (len == 0) Environment.Exit(0);

            List<int> orig = new List<int>();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            // list 1
            for (int i = 0; i < len; i++)
            {
                var entry = int.Parse(Console.ReadLine());
                list1.Add(entry);
                orig.Add(entry);
            }

            // list 2
            for (int i = 0; i < len; i++)
            {
                var entry = int.Parse(Console.ReadLine());
                list2.Add(entry);
            }

            list1.Sort();
            list2.Sort();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < list1.Count(); i++)
            {
                dict.Add(list1[i], list2[i]);
            }

            foreach (var item in orig)
            {
                Console.WriteLine(dict[item]);
            }
        }
    }
}
