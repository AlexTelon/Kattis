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
            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string output = "";

                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[j]) output += ".";
                    else output += "*";
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(output);
            }
        }
    }
}
