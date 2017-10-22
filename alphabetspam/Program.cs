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
            string input = Console.ReadLine();
            double whitespace = 0;
            double lowerCase = 0;
            double upperCase = 0;
            double rest = 0;

            foreach (var token in input)
            {
                if (char.IsLower(token))
                {
                    lowerCase++;
                } else if (char.IsUpper(token))
                {
                    upperCase++;
                } else if (token == '_')
                {
                    whitespace++;
                } else
                {
                    rest++;
                }
            }

            int len = input.Length;

            Console.WriteLine(whitespace / len);
            Console.WriteLine(lowerCase / len);
            Console.WriteLine(upperCase / len);
            Console.WriteLine(rest / len);
        }
    }
}
