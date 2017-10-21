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

            while (true)
            {
                List<int> tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
                int n = tokens[0]; // 0 - 1 000 000
                int m = tokens[1]; // 0 - 1 000 000
                if (n == 0 && m == 0) break;

                // any id is 0 - 1 000 000 000
                var cds = new Dictionary<uint, uint>();
                int sum = 0;

                for (int i = 0; i < n; i++)
                {
                    uint id = uint.Parse(Console.ReadLine());
                    cds[id] = 1;
                }

                for (int i = 0; i < m; i++)
                {
                    uint id = uint.Parse(Console.ReadLine());
                    if (cds.ContainsKey(id)) sum++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
