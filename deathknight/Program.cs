using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //Chains of Ice immediately followed by Death Grip.
                // does not contain CD
                string commands = Console.ReadLine();

                Regex regex = new Regex(@"CD");
                Match match = regex.Match(commands);
                if (!match.Success)
                {
                    sum++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
