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


            // 50 * 1000 complexity

            // max 50 loops
            for (int i = 0; i < n; i++)
            {
                Dictionary<uint, int> data = new Dictionary<uint, int>();

                int guests = int.Parse(Console.ReadLine());
                // listsize max 1000
                List<uint> invitationCode = Console.ReadLine().Split().Select(uint.Parse).ToList();

                foreach (var code in invitationCode)
                {
                    if (!data.ContainsKey(code))
                    {
                        data[code] = 1;
                    } else
                    {
                        data[code]++;
                    }
                }

                Console.Write("Case #{0}: ", i+1);
                Console.WriteLine(data.Where(x => x.Value == 1).ToArray()[0].Key);
            }
        }
    }
}
