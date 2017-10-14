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
                string statement = Console.ReadLine();
                if (statement.StartsWith("Simon says")) Console.WriteLine(statement.Substring(10));
            }
        }
    }
}
