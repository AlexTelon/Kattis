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

            int n = int.Parse(Console.ReadLine());
            var results = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
                int r = input[0];
                int e = input[1];
                int c = input[2];

                int revenueAdds = e - c;

                int delta = r - revenueAdds;

                string result = "advertise";
                if (delta == 0) result = "does not matter";
                if (delta > 0) result = "do not advertise";
                results.Add(result);
            }


            Console.WriteLine(String.Join("\n", results));
        }
    }
}
