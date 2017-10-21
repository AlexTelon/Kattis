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
            int testCaseNumber = 1;
            int n = -1;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n == 0) return;
                Console.WriteLine("SET {0}", testCaseNumber++);

                List<string> names = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    names.Add(Console.ReadLine());
                }

                int nameIndex = 0;

                // loop to end taking every other
                while (nameIndex < n)
                {
                    Console.WriteLine(names[nameIndex]);
                    nameIndex += 2;
                }

                // move us back into the right index at the end
                if (nameIndex == n) nameIndex--;
                if (nameIndex == n + 1) nameIndex -= 3;

                // loop through every other backwards
                while (nameIndex >= 0)
                {
                    Console.WriteLine(names[nameIndex]);
                    nameIndex -= 2;
                }
            }
        }
    }
}
