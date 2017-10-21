using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class Program
    {

        class Solver
        {
            public string Result = "";

            public string DecodeOne(string input)
            {
                string vowels = "aeiou";
                char token = input[0];
                Result += token;

                if (vowels.Contains(token))
                {
                    return input.Substring(3);
                }
                return input.Substring(1);
            }
        }


        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Solver solver = new Solver();

            while (input.Length > 0)
            {
                input = solver.DecodeOne(input);
            }

            Console.WriteLine(solver.Result);
        }
    }
}
