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
                int D = tokens[0];
                int V = tokens[1];
                if (D == 0 && V == 0) return;

                //double area = Math.PI / 4 * (D * D - )

                //double ret = Math.Sqrt(D * D - 4 * V / (Math.PI * D));

                //double area = (D + d)
                double d = Math.Sqrt(2 * Math.PI * V - D * D);
                Console.WriteLine(d);
                //Console.WriteLine(ret);
            }
        }
    }
}
