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

            string text = Console.ReadLine();
            string goal = "Per";
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char a = char.ToUpperInvariant(text[i]);
                char b = char.ToUpperInvariant(goal[i % 3]);

                if (a != b) sum++;
            }
            Console.WriteLine(sum);

        }
    }
}
